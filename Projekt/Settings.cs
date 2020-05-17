using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projekt
{
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
}
