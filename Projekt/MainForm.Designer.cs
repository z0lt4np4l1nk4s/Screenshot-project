namespace Projekt
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.listImage = new System.Windows.Forms.ListBox();
            this.btnShowPictureList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenshot.Location = new System.Drawing.Point(268, 144);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(234, 99);
            this.btnScreenshot.TabIndex = 0;
            this.btnScreenshot.Text = "Screenshot";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(304, 270);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(166, 52);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // listImage
            // 
            this.listImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listImage.FormattingEnabled = true;
            this.listImage.ItemHeight = 16;
            this.listImage.Location = new System.Drawing.Point(25, 51);
            this.listImage.Name = "listImage";
            this.listImage.Size = new System.Drawing.Size(207, 308);
            this.listImage.TabIndex = 2;
            this.listImage.Visible = false;
            this.listImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listImage_MouseDoubleClick);
            // 
            // btnShowPictureList
            // 
            this.btnShowPictureList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPictureList.Location = new System.Drawing.Point(304, 335);
            this.btnShowPictureList.Name = "btnShowPictureList";
            this.btnShowPictureList.Size = new System.Drawing.Size(166, 52);
            this.btnShowPictureList.TabIndex = 3;
            this.btnShowPictureList.Text = "Show picture list";
            this.btnShowPictureList.UseVisualStyleBackColor = true;
            this.btnShowPictureList.Click += new System.EventHandler(this.btnShowPictureList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowPictureList);
            this.Controls.Add(this.listImage);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnScreenshot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ListBox listImage;
        private System.Windows.Forms.Button btnShowPictureList;
    }
}

