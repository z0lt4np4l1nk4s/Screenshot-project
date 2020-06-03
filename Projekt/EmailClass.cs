using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Net.Mime;

namespace Projekt
{
    class EmailClass
    {
        LanguageClass language = new LanguageClass();
        public static string picPath;
        public static string picName;
        public static string picDescription = "";
        
        public void SendEmail(string fromEmail, string password, string toEmail, string subject)
        {
            language.GetEmailDialogText();
            try
            {
                MailMessage mail = new MailMessage(fromEmail, toEmail, subject, picDescription);
                string fpath = picPath + picName;
                MemoryStream memoryStream = new MemoryStream();
                ZipArchive zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create);
                zipArchive.CreateEntryFromFile(fpath, picName);
                zipArchive.Dispose();
                MemoryStream attachment = new MemoryStream(memoryStream.ToArray());
                Attachment file = new Attachment(attachment, "attachment.zip", MediaTypeNames.Application.Zip);
                mail.Attachments.Add(file);
                SmtpClient client = new SmtpClient("smtp.skole.hr", 465);
                client.Credentials = new NetworkCredential(fromEmail, password);
                client.EnableSsl = true;
                client.Send(mail);
                memoryStream.Close();
                attachment.Close();
                MessageBox.Show(language.messageEmailSuccess, language.messageInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(language.messageEmailSendingError, language.messageError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
