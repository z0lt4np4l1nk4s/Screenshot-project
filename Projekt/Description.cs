using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projekt
{
    class Description
    {
        Settings settings = new Settings();
        LanguageClass language = new LanguageClass();
        public string descriptionText { get; set; }
        public static string SelectedPictureDescription;
        public void WriteDescriptionToAFile()
        {
            settings.GetJSONSettings();
            if (settings.settingsFileType == 1)
            {
                settings.GetXMLSettings();
            }
            language.GetDescriptionDialogText();
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
                sw.Close();
            }
            else
            {
                sw = new StreamWriter("description.txt");
                sw.Close();
                WriteDescriptionToAFile();
            }
        }

        public void GetDescriptionFromAFile()
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
                if (string.IsNullOrEmpty(SelectedPictureDescription))
                {
                    SelectedPictureDescription = language.defaultDescription;
                }
                sr.Close();
            }
        }
    }
}
