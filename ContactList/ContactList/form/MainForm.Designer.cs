namespace PhoneBook
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delPersonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSerach = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Info;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.ShowLines = false;
            this.treeView.ShowPlusMinus = false;
            this.treeView.ShowRootLines = false;
            this.treeView.Size = new System.Drawing.Size(584, 834);
            this.treeView.TabIndex = 0;
            this.treeView.DoubleClick += new System.EventHandler(this.treeView_DoubleClick);
            this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseUp);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Folder.png");
            this.imageList.Images.SetKeyName(1, "阿萝~~.jpg");
            this.imageList.Images.SetKeyName(2, "宝玉2.jpg");
            this.imageList.Images.SetKeyName(3, "皇甫3.jpg");
            this.imageList.Images.SetKeyName(4, "姜爹.jpg");
            this.imageList.Images.SetKeyName(5, "啾啾.jpg");
            this.imageList.Images.SetKeyName(6, "兰6.jpg");
            this.imageList.Images.SetKeyName(7, "叔2.jpg");
            this.imageList.Images.SetKeyName(8, "瑕2.jpg");
            this.imageList.Images.SetKeyName(9, "夏孤临.jpg");
            this.imageList.Images.SetKeyName(10, "血手.jpg");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupMenuItem,
            this.addPersonMenuItem,
            this.delGroupMenuItem,
            this.deleteGroupAllMenuItem,
            this.renameMenuItem,
            this.delPersonMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(233, 220);
            // 
            // addGroupMenuItem
            // 
            this.addGroupMenuItem.Name = "addGroupMenuItem";
            this.addGroupMenuItem.Size = new System.Drawing.Size(244, 36);
            this.addGroupMenuItem.Text = "添加分组";
            this.addGroupMenuItem.Click += new System.EventHandler(this.addGroupMenuItem_Click);
            // 
            // addPersonMenuItem
            // 
            this.addPersonMenuItem.Name = "addPersonMenuItem";
            this.addPersonMenuItem.Size = new System.Drawing.Size(244, 36);
            this.addPersonMenuItem.Text = "添加联系人";
            this.addPersonMenuItem.Click += new System.EventHandler(this.addPersonMenuItem_Click);
            // 
            // delGroupMenuItem
            // 
            this.delGroupMenuItem.Name = "delGroupMenuItem";
            this.delGroupMenuItem.Size = new System.Drawing.Size(244, 36);
            this.delGroupMenuItem.Text = "删除分组";
            this.delGroupMenuItem.Visible = false;
            this.delGroupMenuItem.Click += new System.EventHandler(this.delGroupMenuItem_Click);
            // 
            // deleteGroupAllMenuItem
            // 
            this.deleteGroupAllMenuItem.Name = "deleteGroupAllMenuItem";
            this.deleteGroupAllMenuItem.Size = new System.Drawing.Size(244, 36);
            this.deleteGroupAllMenuItem.Text = "完全删除分组";
            this.deleteGroupAllMenuItem.Visible = false;
            this.deleteGroupAllMenuItem.Click += new System.EventHandler(this.deleteGroupAllMenuItem_Click);
            // 
            // renameMenuItem
            // 
            this.renameMenuItem.Name = "renameMenuItem";
            this.renameMenuItem.Size = new System.Drawing.Size(244, 36);
            this.renameMenuItem.Text = "重命名";
            this.renameMenuItem.Visible = false;
            this.renameMenuItem.Click += new System.EventHandler(this.renameMenuItem_Click);
            // 
            // delPersonMenuItem
            // 
            this.delPersonMenuItem.Name = "delPersonMenuItem";
            this.delPersonMenuItem.Size = new System.Drawing.Size(244, 36);
            this.delPersonMenuItem.Text = "删除联系人";
            this.delPersonMenuItem.Visible = false;
            this.delPersonMenuItem.Click += new System.EventHandler(this.delPersonMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 834);
            this.panel1.TabIndex = 1;
            // 
            // textSerach
            // 
            this.textSerach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSerach.Location = new System.Drawing.Point(0, 0);
            this.textSerach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSerach.Multiline = true;
            this.textSerach.Name = "textSerach";
            this.textSerach.Size = new System.Drawing.Size(340, 74);
            this.textSerach.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(334, -2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 77);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(470, 0);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 77);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 902);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSerach);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "通讯录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addGroupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delGroupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delPersonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupAllMenuItem;
        private System.Windows.Forms.TextBox textSerach;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturn;
    }
}

