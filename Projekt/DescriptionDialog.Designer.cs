namespace Projekt
{
    partial class DescriptionDialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblEnterScreenshotDesc = new System.Windows.Forms.Label();
            this.lblWText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(245, 88);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(12, 47);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(323, 26);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // lblEnterScreenshotDesc
            // 
            this.lblEnterScreenshotDesc.AutoSize = true;
            this.lblEnterScreenshotDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterScreenshotDesc.Location = new System.Drawing.Point(13, 13);
            this.lblEnterScreenshotDesc.Name = "lblEnterScreenshotDesc";
            this.lblEnterScreenshotDesc.Size = new System.Drawing.Size(232, 17);
            this.lblEnterScreenshotDesc.TabIndex = 2;
            this.lblEnterScreenshotDesc.Text = "Enter your screenshots description:";
            // 
            // lblWText
            // 
            this.lblWText.AutoSize = true;
            this.lblWText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWText.ForeColor = System.Drawing.Color.Red;
            this.lblWText.Location = new System.Drawing.Point(12, 92);
            this.lblWText.Name = "lblWText";
            this.lblWText.Size = new System.Drawing.Size(223, 17);
            this.lblWText.TabIndex = 3;
            this.lblWText.Text = "Your description cannot be empty!";
            this.lblWText.Visible = false;
            // 
            // DescriptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 125);
            this.Controls.Add(this.lblWText);
            this.Controls.Add(this.lblEnterScreenshotDesc);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DescriptionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblEnterScreenshotDesc;
        private System.Windows.Forms.Label lblWText;
    }
}