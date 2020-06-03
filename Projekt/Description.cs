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
                sw.WriteLine(EmailClass.picPath + EmailClass.picName + " - " + EmailClass.picDescription);
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
                        if (s.Contains(EmailClass.picPath + ImageList.SelectedImageName))
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
