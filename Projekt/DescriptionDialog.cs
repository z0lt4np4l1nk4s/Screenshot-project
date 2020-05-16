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

    class Description
    {
        Settings settings = new Settings();
        public string descriptionText { get; set; }
        public static string SelectedPictureDescription = "No description";
        public void WriteDescriptionToAFile()
        {
            settings.GetSettings();
            StreamWriter sw;
            if (File.Exists("description.txt"))
            {
                sw = File.AppendText("description.txt");
                switch (settings.sIndex)
                {
                    case 0:
                        {
                            sw.WriteLine(settings.fName + "_" + settings.numb + ".jpg" + " - " + descriptionText);
                            break;
                        }
                    case 1:
                        {
                            sw.WriteLine(settings.fName + "_" + settings.numb + ".bmp" + " - " + descriptionText);
                            break;
                        }
                    case 2:
                        {
                            sw.WriteLine(settings.fName + "_" + settings.numb + ".png" + " - " + descriptionText);
                            break;
                        }
                }
                sw.WriteLine(settings.fName + "_" + settings.numb + " - " + descriptionText);
                sw.Close();
            }
            else
            {
                sw = new StreamWriter("description.txt");
                sw.Close();
                WriteDescriptionToAFile();
            }
        }

        public static void GetDescriptionFromAFile()
        {
            if (File.Exists("description.txt"))
            {
                string s;
                StreamReader sr = new StreamReader("description.txt");
                do
                {
                    s = sr.ReadLine();
                    if (!string.IsNullOrEmpty(s))
                    {
                        if (s.Contains(ImageList.SelectedImageName))
                        {
                            SelectedPictureDescription = s;
                        }
                    }
                } while (!(string.IsNullOrEmpty(s)));
                sr.Close();
            }
        }
    }
}
