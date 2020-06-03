using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class DescriptionDialog : Form
    {
        Description description = new Description();
        LanguageClass language = new LanguageClass();
        public DescriptionDialog()
        {
            InitializeComponent();
            language.GetDescriptionDialogText();
            txtDescription.Focus();
            lblEnterScreenshotDesc.Text = language.enterDescription;
            lblWText.Text = language.errorDescription;
            this.Name = language.Description.Replace(":", "");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                lblWText.Visible = true;
            }
            else
            {
                EmailClass.picDescription = txtDescription.Text;
                description.WriteDescriptionToAFile();
                this.Hide();
            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}
