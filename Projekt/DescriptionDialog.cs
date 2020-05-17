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
        public DescriptionDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                lblWText.Visible = true;
                Console.Beep();
            }
            else
            {
                description.descriptionText = txtDescription.Text;
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
