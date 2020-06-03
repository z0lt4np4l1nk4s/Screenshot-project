using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class MainForm : Form
    {
        Settings settings = new Settings();
        LanguageClass language = new LanguageClass();
        EmailClass emailClass = new EmailClass();
        public static MainForm mainForm;
        bool showList = true;
        bool lang = false;
        public static string fromEmail, password, toEmail, subject;

        public MainForm()
        {
            InitializeComponent();
            settings.GetJSONSettings();
            if (settings.settingsFileType == 1)
            {
                settings.GetXMLSettings();
            }
            LanguageClass.languagePath = "language\\" + settings.selectedLanguage + ".json";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainForm = this;
            int i = 0; 
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach(string s in language.availableLanguages)
            {
                cbLanguage.Items.Add(s);
                if((string)cbLanguage.Items[i] == settings.selectedLanguage)
                {
                    cbLanguage.SelectedIndex = i;
                }
                i++;
            }
            language.GetMainFormText();
            LoadText();
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            ListToDefault();
            settings.GetJSONSettings();
            if (settings.settingsFileType == 1)
            {
                settings.GetXMLSettings();
            }
            this.Hide();
            timer.Interval = settings.seconds * 1000;
            timer.Start();
        }
             

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Screenshot screenshot = new Screenshot();
            screenshot.CreateScreenshot(settings.fName, settings.numb.ToString(), settings.path, settings.sIndex);
            if (settings.description)
            {
                DescriptionDialog dd = new DescriptionDialog();
                dd.ShowDialog();
            }
            settings.numb++;
            if (settings.settingsFileType == 1)
            {
                settings.SetXMLSettings(settings);
            }
            else
            {
                settings.SetJSONSettings(settings);
            }
            this.Show();
            if (settings.sendEmailAfterScreenshot)
            {
                emailClass.SendEmail(fromEmail, password, toEmail, subject);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ListToDefault();
            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (settings.settingsFileType == 0)
            {
                settings.SetJSONSettings(settings);
            }
            else
            {
                settings.SetXMLSettings(settings);
            }
            Application.Exit();
        }

        private void btnShowPictureList_Click(object sender, EventArgs e)
        {
            if (showList)
            {
                btnShowPictureList.Text = language.btnHidePictures;
                ImageList imageList = new ImageList();
                foreach (string s in imageList.imgList)
                {
                    listImage.Items.Add(s);
                }
                listImage.Visible = true;
                showList = false;
            }
            else
            {
                btnShowPictureList.Text = language.btnShowPictures;
                listImage.Visible = false;
                showList = true;
                listImage.Items.Clear();
            }           
        }

        private void listImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ImageList.SelectedImageName = (string)listImage.SelectedItem;
            if (!(string.IsNullOrEmpty(ImageList.SelectedImageName)))
            {
                this.Hide();
                ListToDefault();
                PictureForm pictureForm = new PictureForm();
                pictureForm.Show();
            }
            else
            {
                MessageBox.Show(language.messageInvalidSelect, language.messageError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListToDefault()
        {
            listImage.Visible = false;
            btnShowPictureList.Text = language.btnShowPictures;
            showList = true;
            listImage.Items.Clear();
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lang)
            {
                settings.selectedLanguage = cbLanguage.SelectedItem.ToString();
                settings.SetJSONSettings(settings);
                LanguageClass.languagePath = "language\\" + cbLanguage.SelectedItem + ".json";
                language.GetMainFormText();
                LoadText();
            }
            lang = true;
        }

        private void LoadText()
        {
            btnScreenshot.Text = language.btnScreenshot;
            btnSettings.Text = language.Settings;
            btnShowPictureList.Text = language.btnShowPictures;
            lblLanguage.Text = language.language;
        }
    }       
}
