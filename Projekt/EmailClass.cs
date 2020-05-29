using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Projekt
{
    class EmailClass
    {
        LanguageClass language = new LanguageClass();
        public static string picPath;
        public void SendEmail(string fromEmail, string password, string toEmail, string subject)
        {
            language.GetEmailDialogText();
            try
            {
                MailMessage mail = new MailMessage(fromEmail, toEmail, subject, PictureForm.picDescription);
                string fpath = picPath + PictureForm.picName;
                Attachment file = new Attachment(fpath);
                mail.Attachments.Add(file);
                SmtpClient client = new SmtpClient("smtp.skole.hr", 465);
                client.Credentials = new NetworkCredential(fromEmail, password);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show(language.messageEmailSuccess, language.messageInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(language.messageEmailSendingError, language.messageError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
