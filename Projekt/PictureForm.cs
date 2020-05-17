using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class PictureForm : Form
    {
        Settings settings = new Settings();
        MainForm mf = new MainForm();
        public PictureForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.mainForm.Show();
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {
            try
            {
                settings.GetSettings();
                Description.GetDescriptionFromAFile();
                lblFileName.Text = ImageList.SelectedImageName;
                lblDescription.Text = Description.SelectedPictureDescription.Replace(ImageList.SelectedImageName + " - ", ""); 
                pbScreenshot.Image = Image.FromFile(settings.path + ImageList.SelectedImageName);
            }
            catch
            {
                MessageBox.Show("Picture not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void PictureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
