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
using System.Security.Cryptography;

namespace Projekt
{
    class EmailClass
    {
        LanguageClass language = new LanguageClass();
        public static string picPath;
        public static string picName;
        public static string picDescription = "";
        AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();

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

        public void SaveEmailDetails(string fromEmail, string password, string toEmail, string subject)
        {
            StreamWriter sw = new StreamWriter("EmailDetails.txt");
            sw.WriteLine(EncryptEmailDetails(fromEmail));
            sw.WriteLine(EncryptEmailDetails(password));
            sw.WriteLine(EncryptEmailDetails(toEmail));
            sw.WriteLine(EncryptEmailDetails(subject));
            sw.Close();
        }

        private string EncryptEmailDetails(string text)
        {
            byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(text);
            CryptoService();
            ICryptoTransform icrypt = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
            byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();
            return Convert.ToBase64String(enc);
        }

        public void GetEmailDetails()
        {
            if (File.Exists("EmailDetails.txt") && File.ReadAllText("EmailDetails.txt") != "")
            {
                StreamReader sr = new StreamReader("EmailDetails.txt");
                MainForm.fromEmail = DecryptEmailDetails(sr.ReadLine());
                MainForm.password = DecryptEmailDetails(sr.ReadLine());
                MainForm.toEmail = DecryptEmailDetails(sr.ReadLine());
                MainForm.subject = DecryptEmailDetails(sr.ReadLine());
                sr.Close();
            }
            else
            {
                MainForm.fromEmail = "";
                MainForm.password = "";
                MainForm.toEmail = "";
                MainForm.subject = "";
            }
        }

        public string DecryptEmailDetails(string text)
        {
            byte[] textbytes = Convert.FromBase64String(text);
            CryptoService();
            ICryptoTransform icrypt = aesCryptoServiceProvider.CreateDecryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
            byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();
            return System.Text.ASCIIEncoding.ASCII.GetString(enc);
        }

        private void CryptoService()
        {
            aesCryptoServiceProvider.BlockSize = 128;
            aesCryptoServiceProvider.KeySize = 256;
            aesCryptoServiceProvider.IV = ASCIIEncoding.ASCII.GetBytes("0123456789abcdef");
            aesCryptoServiceProvider.Key = ASCIIEncoding.ASCII.GetBytes("0123456789abcdef0123456789abcdef");
            aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
            aesCryptoServiceProvider.Mode = CipherMode.CBC;
        }
    }
}
