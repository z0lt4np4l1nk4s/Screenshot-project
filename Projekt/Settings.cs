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
        public int settingsFileType { get; set; }
        public Settings()
        {
            fName = "Untitled";
            numb = 1;
            path = @"C:\Users\" + Environment.UserName + @"\Pictures\";
            check = false;
            seconds = 3;
            sIndex = 0;
            description = false;
            settingsFileType = 0;
        }

        public void SetJSONSettings(Settings settings)
        {
            string json = JsonConvert.SerializeObject(settings);
            File.WriteAllText("settings.json", json);
        }

        public void GetJSONSettings()
        {
            if (File.Exists("settings.json"))
            {
                try
                {
                    JObject jObject = JObject.Parse(File.ReadAllText("settings.json"));
                    fName = (string)jObject["fName"];
                    numb = (int)jObject["numb"];
                    path = (string)jObject["path"];
                    check = (bool)jObject["check"];
                    seconds = (int)jObject["seconds"];
                    sIndex = (int)jObject["sIndex"];
                    description = (bool)jObject["description"];
                    settingsFileType = (int)jObject["settingsFileType"];
                }
                catch
                {
                    Settings settings = new Settings();
                    SetJSONSettings(settings);
                }
            }
            else
            {
                Settings settings = new Settings();
                SetJSONSettings(settings);
            }
        }

        public void SetXMLSettings(Settings settings)
        {
            XmlSerializer writer = new XmlSerializer(typeof(Settings));
            FileStream file = File.Create("settings.xml");
            settings.settingsFileType = 1;
            writer.Serialize(file, settings);
            file.Close();
        }

        public void GetXMLSettings()
        {
            if (File.Exists("settings.xml"))
            {
                try
                {
                    XElement element = XElement.Load("settings.xml");
                    fName = element.Element("fName").Value;
                    numb = int.Parse(element.Element("numb").Value);
                    path = element.Element("path").Value;
                    check = bool.Parse(element.Element("check").Value);
                    seconds = int.Parse(element.Element("seconds").Value);
                    sIndex = int.Parse(element.Element("sIndex").Value);
                    description = bool.Parse(element.Element("description").Value);
                    settingsFileType = int.Parse(element.Element("settingsFileType").Value);
                }
                catch
                {
                    Settings settings = new Settings();
                    SetXMLSettings(settings);
                }
            }
            else
            {
                Settings settings = new Settings();
                SetXMLSettings(settings);
            }
        }
    }
}
