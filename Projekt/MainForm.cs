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

namespace Projekt
{
    public partial class MainForm : Form
    {
        Settings settings = new Settings();
        Screenshot screenshot = new Screenshot();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settings.GetSettings();
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
            imageList.GetImageList();
            foreach(string s in imageList.imgList)
            {
                listImage.Items.Add(s);
            }
            listImage.Visible = true;
        }

        private void listImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ImageList imageList = new ImageList();
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

    class Settings
    {
        public string fName { get; set; }
        public int numb { get; set; }
        public string path { get; set; }
        public bool check { get; set; }
        public int seconds { get; set; }
        public int sIndex { get; set; }
        public bool description { get; set; }
        public Settings()
        {
            fName = "Untitled";
            numb = 1;
            path = @"C:\Users\" + Environment.UserName + @"\Pictures\";
            check = false;
            seconds = 3;
            sIndex = 0;
            description = false;
        }

        public void GetSettings()
        {
            if (File.Exists("settings.txt"))
            {
                StreamReader sr = new StreamReader("settings.txt");
                try
                {
                    fName = sr.ReadLine();
                    numb = int.Parse(sr.ReadLine());
                    path = sr.ReadLine();
                    check = bool.Parse(sr.ReadLine());
                    seconds = int.Parse(sr.ReadLine());
                    sIndex = int.Parse(sr.ReadLine());
                    description = bool.Parse(sr.ReadLine());
                    sr.Close();
                }
                catch
                {
                    sr.Close();
                    SetSettings();
                }
            }
            else
            {
                SetSettings();
            }
        }

        public void SetSettings()
        {
            StreamWriter sw = new StreamWriter("settings.txt");
            sw.WriteLine(fName);
            sw.WriteLine(numb);
            sw.WriteLine(path);
            sw.WriteLine(check);
            sw.WriteLine(seconds);
            sw.WriteLine(sIndex);
            sw.WriteLine(description);
            sw.Close();
        }
    }

    class Screenshot
    {
        public void CreateScreenshot(string FileName, string Number, string Path, int sIndex)
        {
            try
            {
                Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(bitmap as Image);
                graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                if (sIndex == 0)
                {
                    bitmap.Save(Path + FileName + "_" + Number + ".jpg", ImageFormat.Jpeg);
                }
                else if (sIndex == 1)
                {
                    bitmap.Save(Path + FileName + "_" + Number + ".bmp", ImageFormat.Bmp);
                }
                else if (sIndex == 2)
                {
                    bitmap.Save(Path + FileName + "_" + Number + ".png", ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    class ImageList
    {
        Settings settings = new Settings();
        public List<string> imgList = new List<string>();

        public static string SelectedImageName;
        public void GetImageList()
        {
            settings.GetSettings();
            DirectoryInfo di = new DirectoryInfo(settings.path);
            foreach(FileInfo fi in di.GetFiles())
            {
                if (fi.Name.Contains(".jpg")) imgList.Add(fi.Name);
                if (fi.Name.Contains(".bmp")) imgList.Add(fi.Name);
                if (fi.Name.Contains(".png")) imgList.Add(fi.Name);
            }
        }
    }
}
