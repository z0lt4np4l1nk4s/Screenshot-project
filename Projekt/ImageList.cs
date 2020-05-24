using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projekt
{
    class ImageList
    {
        public static string SelectedImageName;
        private List<string> _img = new List<string>();
        public List<string> imgList
        {
            get
            {
                
                Settings settings = new Settings();
                settings.GetJSONSettings();
                if (settings.settingsFileType == 1)
                {
                    settings.GetXMLSettings();
                }
                DirectoryInfo di = new DirectoryInfo(settings.path);
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Name.Contains(".jpg")) _img.Add(fi.Name);
                    if (fi.Name.Contains(".bmp")) _img.Add(fi.Name);
                    if (fi.Name.Contains(".png")) _img.Add(fi.Name);
                }
                return this._img;
            }
        }
    }
}
