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
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;

namespace Projekt
{
    public partial class MainForm : Form
    {
        Settings settings = new Settings();
        public static MainForm mainForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settings.GetSettings();
            mainForm = this;
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
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
            this.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            settings.SetSettings();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings.SetSettings();
            Application.Exit();
        }

        private void btnShowPictureList_Click(object sender, EventArgs e)
        {
            ImageList imageList = new ImageList();
            foreach(string s in imageList.imgList)
            {
                listImage.Items.Add(s);
            }

            listImage.Visible = true;
        }

        private void listImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ImageList.SelectedImageName = (string)listImage.SelectedItem;
            if (!(string.IsNullOrEmpty(ImageList.SelectedImageName)))
            {
                this.Hide();
                PictureForm pictureForm = new PictureForm();
                pictureForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid select", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }       
}
