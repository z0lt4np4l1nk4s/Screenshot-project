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
        LanguageClass language = new LanguageClass();
        public static string picDescription, picName;
        public PictureForm()
        {
            InitializeComponent();
            language.GetPictureFormText();
            btnBack.Text = language.btnBack;
            btnSendAsEmail.Text = language.btnSendAsEmail;
            lblDescr.Text = language.Description;
            lblDescription.Text = language.defaultDescription;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.mainForm.Show();
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {
            Description description = new Description();
            try
            {
                settings.GetJSONSettings();
                if (settings.settingsFileType == 1)
                {
                    settings.GetXMLSettings();
                }
                description.GetDescriptionFromAFile();
                lblFileName.Text = ImageList.SelectedImageName;
                if (Description.SelectedPictureDescription.Contains(settings.path + ImageList.SelectedImageName))
                {
                    lblDescription.Text = Description.SelectedPictureDescription.Replace(settings.path + ImageList.SelectedImageName + " - ", "");
                    EmailClass.picDescription = lblDescription.Text;
                }
                else
                {
                    lblDescription.Text = language.defaultDescription;
                }
                pbScreenshot.Image = Image.FromFile(settings.path + ImageList.SelectedImageName);
            }
            catch
            {
                MessageBox.Show(language.messagePictureNotFound, language.messageError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void PictureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSendAsEmail_Click(object sender, EventArgs e)
        {
            btnSendAsEmail.Enabled = false;
            btnBack.Enabled = false;
            picDescription = lblDescription.Text;
            EmailClass.picName = lblFileName.Text;
            EmailDialog email = new EmailDialog();
            email.Show();
        }

        private void PictureForm_Activated(object sender, EventArgs e)
        {
            btnSendAsEmail.Enabled = true;
            btnBack.Enabled = true;
        }
    }
}
