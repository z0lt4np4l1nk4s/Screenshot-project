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
        public static MainForm mainForm;
        bool showList = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainForm = this;
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
                btnShowPictureList.Text = "Hide list";
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
                btnShowPictureList.Text = "Show picture list";
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
                MessageBox.Show("Invalid select", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListToDefault()
        {
            listImage.Visible = false;
            btnShowPictureList.Text = "Show picture list";
            showList = true;
            listImage.Items.Clear();
        }
    }       
}
