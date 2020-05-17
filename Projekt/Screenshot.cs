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
}
