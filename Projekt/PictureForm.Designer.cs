﻿namespace Projekt
{
    partial class PictureForm
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
            this.pbScreenshot = new System.Windows.Forms.PictureBox();
            this.lblDescr = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSendAsEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // pbScreenshot
            // 
            this.pbScreenshot.Location = new System.Drawing.Point(12, 55);
            this.pbScreenshot.Name = "pbScreenshot";
            this.pbScreenshot.Size = new System.Drawing.Size(776, 363);
            this.pbScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScreenshot.TabIndex = 0;
            this.pbScreenshot.TabStop = false;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(8, 421);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(93, 20);
            this.lblDescr.TabIndex = 2;
            this.lblDescr.Text = "Description:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 37);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(107, 421);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(110, 20);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "No description";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(355, 20);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(81, 20);
            this.lblFileName.TabIndex = 18;
            this.lblFileName.Text = "filename...";
            // 
            // btnSendAsEmail
            // 
            this.btnSendAsEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendAsEmail.Location = new System.Drawing.Point(633, 12);
            this.btnSendAsEmail.Name = "btnSendAsEmail";
            this.btnSendAsEmail.Size = new System.Drawing.Size(155, 37);
            this.btnSendAsEmail.TabIndex = 19;
            this.btnSendAsEmail.Text = "Send as email";
            this.btnSendAsEmail.UseVisualStyleBackColor = true;
            this.btnSendAsEmail.Click += new System.EventHandler(this.btnSendAsEmail_Click);
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendAsEmail);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.pbScreenshot);
            this.Name = "PictureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureForm";
            this.Activated += new System.EventHandler(this.PictureForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PictureForm_FormClosed);
            this.Load += new System.EventHandler(this.PictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScreenshot;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSendAsEmail;
    }
}