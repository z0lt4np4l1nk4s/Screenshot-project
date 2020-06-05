namespace Projekt
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lblSaveF = new System.Windows.Forms.Label();
            this.lblSaveFolder = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.lblDeleteFiles = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSecTimer = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.s = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtToEmail = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblYourEmail = new System.Windows.Forms.Label();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbSendEmailAfterScreenshot = new System.Windows.Forms.CheckBox();
            this.cbSettingsFileType = new System.Windows.Forms.ComboBox();
            this.lblSetFType = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDescDisable = new System.Windows.Forms.RadioButton();
            this.rbDescEnable = new System.Windows.Forms.RadioButton();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblFileType = new System.Windows.Forms.Label();
            this.lblStartNumber = new System.Windows.Forms.Label();
            this.numStartNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbEmail.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaveF
            // 
            this.lblSaveF.AutoSize = true;
            this.lblSaveF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveF.Location = new System.Drawing.Point(26, 94);
            this.lblSaveF.Name = "lblSaveF";
            this.lblSaveF.Size = new System.Drawing.Size(98, 20);
            this.lblSaveF.TabIndex = 0;
            this.lblSaveF.Text = "Save Folder:";
            // 
            // lblSaveFolder
            // 
            this.lblSaveFolder.AutoSize = true;
            this.lblSaveFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveFolder.Location = new System.Drawing.Point(236, 94);
            this.lblSaveFolder.Name = "lblSaveFolder";
            this.lblSaveFolder.Size = new System.Drawing.Size(29, 20);
            this.lblSaveFolder.TabIndex = 1;
            this.lblSaveFolder.Text = ".....";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(141, 88);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(89, 32);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.Location = new System.Drawing.Point(6, 13);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(55, 24);
            this.rbYes.TabIndex = 3;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(113, 13);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(47, 24);
            this.rbNo.TabIndex = 4;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // lblDeleteFiles
            // 
            this.lblDeleteFiles.AutoSize = true;
            this.lblDeleteFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteFiles.Location = new System.Drawing.Point(26, 157);
            this.lblDeleteFiles.Name = "lblDeleteFiles";
            this.lblDeleteFiles.Size = new System.Drawing.Size(260, 20);
            this.lblDeleteFiles.TabIndex = 5;
            this.lblDeleteFiles.Text = "Delete all files from selected folder?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Location = new System.Drawing.Point(439, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 44);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblSecTimer
            // 
            this.lblSecTimer.AutoSize = true;
            this.lblSecTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecTimer.Location = new System.Drawing.Point(26, 216);
            this.lblSecTimer.Name = "lblSecTimer";
            this.lblSecTimer.Size = new System.Drawing.Size(131, 20);
            this.lblSecTimer.TabIndex = 7;
            this.lblSecTimer.Text = "Seconds in timer:";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(116, 25);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(175, 26);
            this.txtFileName.TabIndex = 8;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(26, 28);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(84, 20);
            this.lblFileName.TabIndex = 9;
            this.lblFileName.Text = "File Name:";
            // 
            // numSeconds
            // 
            this.numSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSeconds.Location = new System.Drawing.Point(188, 214);
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(175, 26);
            this.numSeconds.TabIndex = 10;
            this.numSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(371, 216);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(17, 20);
            this.s.TabIndex = 11;
            this.s.Text = "s";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(430, 9);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(99, 26);
            this.lblSettings.TabIndex = 12;
            this.lblSettings.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbEmail);
            this.groupBox2.Controls.Add(this.cbSendEmailAfterScreenshot);
            this.groupBox2.Controls.Add(this.cbSettingsFileType);
            this.groupBox2.Controls.Add(this.lblSetFType);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblDesc);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.lblFileType);
            this.groupBox2.Controls.Add(this.lblStartNumber);
            this.groupBox2.Controls.Add(this.numStartNumber);
            this.groupBox2.Controls.Add(this.lblSecTimer);
            this.groupBox2.Controls.Add(this.numSeconds);
            this.groupBox2.Controls.Add(this.lblFileName);
            this.groupBox2.Controls.Add(this.s);
            this.groupBox2.Controls.Add(this.txtFileName);
            this.groupBox2.Controls.Add(this.lblDeleteFiles);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblSaveF);
            this.groupBox2.Controls.Add(this.lblSaveFolder);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 438);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.txtSubject);
            this.gbEmail.Controls.Add(this.txtToEmail);
            this.gbEmail.Controls.Add(this.lblInfo);
            this.gbEmail.Controls.Add(this.lblPassword);
            this.gbEmail.Controls.Add(this.lblYourEmail);
            this.gbEmail.Controls.Add(this.txtFromEmail);
            this.gbEmail.Controls.Add(this.txtPassword);
            this.gbEmail.Controls.Add(this.lblSubject);
            this.gbEmail.Controls.Add(this.lblTo);
            this.gbEmail.Location = new System.Drawing.Point(511, 251);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(443, 168);
            this.gbEmail.TabIndex = 42;
            this.gbEmail.TabStop = false;
            this.gbEmail.Visible = false;
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(113, 118);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(290, 26);
            this.txtSubject.TabIndex = 45;
            // 
            // txtToEmail
            // 
            this.txtToEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToEmail.Location = new System.Drawing.Point(113, 86);
            this.txtToEmail.Name = "txtToEmail";
            this.txtToEmail.Size = new System.Drawing.Size(290, 26);
            this.txtToEmail.TabIndex = 44;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Image = ((System.Drawing.Image)(resources.GetObject("lblInfo.Image")));
            this.lblInfo.Location = new System.Drawing.Point(411, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(25, 24);
            this.lblInfo.TabIndex = 46;
            this.lblInfo.Text = "   ";
            this.ToolTip.SetToolTip(this.lblInfo, "Use your AAI@EduHr email!");
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(19, 57);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 50;
            this.lblPassword.Text = "Password:";
            // 
            // lblYourEmail
            // 
            this.lblYourEmail.AutoSize = true;
            this.lblYourEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourEmail.Location = new System.Drawing.Point(19, 25);
            this.lblYourEmail.Name = "lblYourEmail";
            this.lblYourEmail.Size = new System.Drawing.Size(88, 20);
            this.lblYourEmail.TabIndex = 49;
            this.lblYourEmail.Text = "Your email:";
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromEmail.Location = new System.Drawing.Point(113, 22);
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(290, 26);
            this.txtFromEmail.TabIndex = 42;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(113, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(290, 26);
            this.txtPassword.TabIndex = 43;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(19, 121);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(67, 20);
            this.lblSubject.TabIndex = 48;
            this.lblSubject.Text = "Subject:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(19, 89);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(31, 20);
            this.lblTo.TabIndex = 47;
            this.lblTo.Text = "To:";
            // 
            // cbSendEmailAfterScreenshot
            // 
            this.cbSendEmailAfterScreenshot.AutoSize = true;
            this.cbSendEmailAfterScreenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSendEmailAfterScreenshot.Location = new System.Drawing.Point(511, 216);
            this.cbSendEmailAfterScreenshot.Name = "cbSendEmailAfterScreenshot";
            this.cbSendEmailAfterScreenshot.Size = new System.Drawing.Size(290, 24);
            this.cbSendEmailAfterScreenshot.TabIndex = 28;
            this.cbSendEmailAfterScreenshot.Text = "Send image in email after screenshot";
            this.cbSendEmailAfterScreenshot.UseVisualStyleBackColor = true;
            this.cbSendEmailAfterScreenshot.CheckedChanged += new System.EventHandler(this.cbSendEmailAfterScreenshot_CheckedChanged);
            // 
            // cbSettingsFileType
            // 
            this.cbSettingsFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSettingsFileType.FormattingEnabled = true;
            this.cbSettingsFileType.Location = new System.Drawing.Point(190, 391);
            this.cbSettingsFileType.Name = "cbSettingsFileType";
            this.cbSettingsFileType.Size = new System.Drawing.Size(173, 28);
            this.cbSettingsFileType.TabIndex = 26;
            this.cbSettingsFileType.SelectedIndexChanged += new System.EventHandler(this.cbSettingsFileType_SelectedIndexChanged);
            // 
            // lblSetFType
            // 
            this.lblSetFType.AutoSize = true;
            this.lblSetFType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetFType.Location = new System.Drawing.Point(26, 395);
            this.lblSetFType.Name = "lblSetFType";
            this.lblSetFType.Size = new System.Drawing.Size(130, 20);
            this.lblSetFType.TabIndex = 25;
            this.lblSetFType.Text = "Settings file type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDescDisable);
            this.groupBox3.Controls.Add(this.rbDescEnable);
            this.groupBox3.Location = new System.Drawing.Point(121, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 47);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // rbDescDisable
            // 
            this.rbDescDisable.AutoSize = true;
            this.rbDescDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescDisable.Location = new System.Drawing.Point(114, 11);
            this.rbDescDisable.Name = "rbDescDisable";
            this.rbDescDisable.Size = new System.Drawing.Size(80, 24);
            this.rbDescDisable.TabIndex = 1;
            this.rbDescDisable.TabStop = true;
            this.rbDescDisable.Text = "Disable";
            this.rbDescDisable.UseVisualStyleBackColor = true;
            // 
            // rbDescEnable
            // 
            this.rbDescEnable.AutoSize = true;
            this.rbDescEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescEnable.Location = new System.Drawing.Point(6, 11);
            this.rbDescEnable.Name = "rbDescEnable";
            this.rbDescEnable.Size = new System.Drawing.Size(77, 24);
            this.rbDescEnable.TabIndex = 0;
            this.rbDescEnable.TabStop = true;
            this.rbDescEnable.Text = "Enable";
            this.rbDescEnable.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(26, 335);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(93, 20);
            this.lblDesc.TabIndex = 22;
            this.lblDesc.Text = "Description:";
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(150, 275);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(175, 28);
            this.cbType.TabIndex = 15;
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileType.Location = new System.Drawing.Point(26, 278);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(76, 20);
            this.lblFileType.TabIndex = 14;
            this.lblFileType.Text = "File Type:";
            // 
            // lblStartNumber
            // 
            this.lblStartNumber.AutoSize = true;
            this.lblStartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartNumber.Location = new System.Drawing.Point(463, 28);
            this.lblStartNumber.Name = "lblStartNumber";
            this.lblStartNumber.Size = new System.Drawing.Size(108, 20);
            this.lblStartNumber.TabIndex = 13;
            this.lblStartNumber.Text = "Start Number:";
            // 
            // numStartNumber
            // 
            this.numStartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStartNumber.Location = new System.Drawing.Point(577, 26);
            this.numStartNumber.Name = "numStartNumber";
            this.numStartNumber.Size = new System.Drawing.Size(175, 26);
            this.numStartNumber.TabIndex = 12;
            this.numStartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(385, 509);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(230, 40);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 37);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaveF;
        private System.Windows.Forms.Label lblSaveFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label lblDeleteFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSecTimer;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStartNumber;
        private System.Windows.Forms.NumericUpDown numStartNumber;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDescDisable;
        private System.Windows.Forms.RadioButton rbDescEnable;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblSetFType;
        private System.Windows.Forms.ComboBox cbSettingsFileType;
        private System.Windows.Forms.CheckBox cbSendEmailAfterScreenshot;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtToEmail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblYourEmail;
        private System.Windows.Forms.TextBox txtFromEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblTo;
    }
}