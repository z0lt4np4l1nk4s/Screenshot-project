using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;

namespace Projekt
{
    class Screenshot
    {
        LanguageClass language = new LanguageClass();
        public void CreateScreenshot(string FileName, string Number, string Path, int sIndex)
        {
            language.GetScreenshotText();
            try
            {
                Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(bitmap as Image);
                graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                if (sIndex == 0)
                {
                    bitmap.Save(Path + FileName + "_" + Number + ".jpg", ImageFormat.Jpeg);
                    EmailClass.picName = FileName + "_" + Number + ".jpg";
                }
                else if (sIndex == 1)
                {
                    bitmap.Save(Path + FileName + "_" + Number + ".bmp", ImageFormat.Bmp);
                    EmailClass.picName = FileName + "_" + Number + ".bmp";
                }
                else if (sIndex == 2)
                {
                    bitmap.Save(Path + FileName + "_" + Number + ".png", ImageFormat.Png);
                    EmailClass.picName = FileName + "_" + Number + ".png";
                }
                EmailClass.picPath = Path;
            }
            catch
            {
                MessageBox.Show(language.messageScreenshotError, language.messageError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
