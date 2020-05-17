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
        public List<string> imgList
        {
            get
            {
                Settings settings = new Settings();
                settings.GetSettings();
                DirectoryInfo di = new DirectoryInfo(settings.path);
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Name.Contains(".jpg")) imgList.Add(fi.Name);
                    if (fi.Name.Contains(".bmp")) imgList.Add(fi.Name);
                    if (fi.Name.Contains(".png")) imgList.Add(fi.Name);
                }
                return this.imgList;
            }
        }
    }
}
