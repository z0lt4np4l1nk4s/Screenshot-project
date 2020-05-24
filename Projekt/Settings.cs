using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Projekt
{
    public class Settings
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

        public void SetJSONSettings(Settings settings)
        {
            string json = JsonConvert.SerializeObject(settings);
            File.WriteAllText("settings.json", json);
        }

        public void GetJSONSettings()
        {
            JObject jObject = JObject.Parse(File.ReadAllText("settings.json"));
            fName = (string)jObject["fName"];
            numb = (int)jObject["numb"];
            path = (string)jObject["path"];
            check = (bool)jObject["check"];
            seconds = (int)jObject["seconds"];
            sIndex = (int)jObject["sIndex"];
            description = (bool)jObject["description"];
        }

        public void SetXMLSettings(Settings settings)
        {
            XmlSerializer writer = new XmlSerializer(typeof(Settings));
            FileStream file = File.Create("settings.xml");
            writer.Serialize(file, settings);
            file.Close();
        }

        public void GetXMLSettings()
        {
            XElement element = XElement.Load("settings.xml");
            fName = element.Element("fName").Value;
            numb = int.Parse(element.Element("numb").Value);
            path = element.Element("path").Value;
            check = bool.Parse(element.Element("check").Value);
            seconds = int.Parse(element.Element("seconds").Value);
            sIndex = int.Parse(element.Element("sIndex").Value);
            description = bool.Parse(element.Element("description").Value);
        }
    }
}
