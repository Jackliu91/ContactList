namespace PhoneBook
{
    partial class PersonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTelphoe = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.telephoneText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.remarkText = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(21, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(105, 104);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(146, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // lblTelphoe
            // 
            this.lblTelphoe.AutoSize = true;
            this.lblTelphoe.Location = new System.Drawing.Point(146, 103);
            this.lblTelphoe.Name = "lblTelphoe";
            this.lblTelphoe.Size = new System.Drawing.Size(37, 15);
            this.lblTelphoe.TabIndex = 2;
            this.lblTelphoe.Text = "手机";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(18, 223);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(37, 15);
            this.lblRemark.TabIndex = 6;
            this.lblRemark.Text = "备注";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(189, 43);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(166, 25);
            this.nameText.TabIndex = 1;
            // 
            // telephoneText
            // 
            this.telephoneText.Location = new System.Drawing.Point(189, 100);
            this.telephoneText.MaxLength = 11;
            this.telephoneText.Name = "telephoneText";
            this.telephoneText.Size = new System.Drawing.Size(166, 25);
            this.telephoneText.TabIndex = 3;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(79, 163);
            this.emailText.MaxLength = 20;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(276, 25);
            this.emailText.TabIndex = 5;
            // 
            // remarkText
            // 
            this.remarkText.Location = new System.Drawing.Point(79, 220);
            this.remarkText.Multiline = true;
            this.remarkText.Name = "remarkText";
            this.remarkText.Size = new System.Drawing.Size(276, 105);
            this.remarkText.TabIndex = 7;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(149, 349);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "确定";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "阿萝~~.jpg");
            this.imageList.Images.SetKeyName(1, "宝玉2.jpg");
            this.imageList.Images.SetKeyName(2, "皇甫3.jpg");
            this.imageList.Images.SetKeyName(3, "姜爹.jpg");
            this.imageList.Images.SetKeyName(4, "啾啾.jpg");
            this.imageList.Images.SetKeyName(5, "兰6.jpg");
            this.imageList.Images.SetKeyName(6, "叔2.jpg");
            this.imageList.Images.SetKeyName(7, "瑕2.jpg");
            this.imageList.Images.SetKeyName(8, "夏孤临.jpg");
            this.imageList.Images.SetKeyName(9, "血手.jpg");
            // 
            // PersonForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.remarkText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.telephoneText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelphoe);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "联系人";
            this.Activated += new System.EventHandler(this.PersonForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTelphoe;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox telephoneText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox remarkText;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ImageList imageList;
    }
}