using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Projekt
{
    class LanguageClass
    {
        private List<string> lang = new List<string>();
        public List<string> availableLanguages
        {
            get
            {
                DirectoryInfo di = new DirectoryInfo("language");
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Name.Contains(".json")) lang.Add(Path.GetFileNameWithoutExtension(fi.Name));
                }
                return lang;
            }
        }

        public string btnScreenshot { get; set; }
        public string Settings { get; set; }
        public string btnShowPictures { get; set; }
        public string btnHidePictures { get; set; }
        public string language { get; set; }

        public string btnBack { get; set; }
        public string FileName { get; set; }
        public string StartNumber { get; set; }
        public string SaveFolder { get; set; }
        public string btnBrowse { get; set; }
        public string DeleteAllFiles { get; set; }
        public string rbYes { get; set; }
        public string rbNo { get; set; }
        public string secInTimer { get; set; }
        public string settingFType { get; set; }
        public string FType { get; set; }
        public string Description { get; set; }
        public string rbEnable { get; set; }
        public string rbDisable { get; set; }
        public string SaveChanges { get; set; }
        public string SendEmailAfterScreenshot { get; set; }

        public string defaultDescription { get; set; }
        public string btnSendAsEmail { get; set; }

        public string fromEmail { get; set; }
        public string password { get; set; }
        public string toEmail { get; set; }
        public string subject { get; set; }
        public string btnSend { get; set; }
        public string btnSending { get; set; }
        public string info { get; set; }

        public string enterDescription { get; set; }
        public string errorDescription { get; set; }

        public string messageInvalidSelect { get; set; }
        public string messageAreYouSureToDelete { get; set; }
        public string messageChangesSaved { get; set; }
        public string messageAllFields { get; set; }
        public string messageUnsavedChanges { get; set; }
        public string messagePictureNotFound { get; set; }
        public string messageInvalidEmail { get; set; }
        public string messageSendWithoutSubject { get; set; }
        public string messageEmailSendingError { get; set; }
        public string messageEmailSuccess { get; set; }
        public string messageScreenshotError { get; set; }

        public string messageWarning { get; set; }
        public string messageQuestion { get; set; }
        public string messageInformation { get; set; }
        public string messageError { get; set; }
        public static string languagePath = "language\\EN.json";

        public LanguageClass()
        {
            btnScreenshot = "Screenshot";
            Settings = "Settings";
            btnShowPictures = "Show picture list";
            btnHidePictures = "Hide list";
            language = "Language";
            btnBack = "Back";
            FileName = "File Name:";
            StartNumber = "Start Number:";
            SaveFolder = "Save Folder:";
            btnBrowse = "Browse";
            DeleteAllFiles = "Delete all files from selected folder?";
            rbYes = "Yes";
            rbNo = "No";
            secInTimer = "Seconds in timer:";
            settingFType = "Settings file type:";
            FType = "File Type:";
            Description = "Description:";
            rbEnable = "Enable";
            rbDisable = "Disable";
            SaveChanges = "Save Changes";
            SendEmailAfterScreenshot = "Send image in email after screenshot";
            defaultDescription = "No description";
            btnSendAsEmail = "Send as email";
            fromEmail = "Your email:";
            password = "Password:";
            toEmail = "To:";
            subject = "Subject:";
            btnSend = "Send";
            btnSending = "Sending...";
            info = "Use your AAI@EduHr email!";
            enterDescription = "Enter your screenshots description:";
            errorDescription = "Your description cannot be empty!";
            messageInvalidSelect = "Invalid select";
            messageAreYouSureToDelete = "Are you sure you want delete all files from selected folder?";
            messageChangesSaved = "Changes saved succesfully!";
            messageAllFields = "All fields must be filled!";
            messageUnsavedChanges = "You have some unsaved changes, do you want to save them?";
            messagePictureNotFound = "Picture not found!";
            messageSendWithoutSubject = "Are you sure that you want to send the email without a subject?";
            messageEmailSendingError = "An error occoured while sending the email, please try again later!";
            messageEmailSuccess = "Email sended successfully";
            messageInvalidEmail = "Invalid email adress!";
            messageWarning = "Warning";
            messageQuestion = "Question";
            messageInformation = "Information";
            messageError = "Error";
        }

        public void GetDescriptionDialogText()
        {
            if (File.Exists(languagePath))
            {
                JObject jObject = JObject.Parse(File.ReadAllText(languagePath));
                Description = (string)jObject["Description"];
                enterDescription = (string)jObject["enterDescription"];
                errorDescription = (string)jObject["errorDescription"];
            }
        }

        public void GetScreenshotText()
        {
            if (File.Exists(languagePath))
            {
                JObject jObject = JObject.Parse(File.ReadAllText(languagePath));
                messageScreenshotError = (string)jObject["messageScreenshotError"];
                messageError = (string)jObject["messageError"];
            }
        }

        public void GetEmailDialogText()
        {
            if (File.Exists(languagePath))
            {
                JObject jObject = JObject.Parse(File.ReadAllText(languagePath));
                fromEmail = (string)jObject["fromEmail"];
                password = (string)jObject["password"];
                toEmail = (string)jObject["toEmail"];
                subject = (string)jObject["subject"];
                btnSend = (string)jObject["btnSend"];
                btnSending = (string)jObject["btnSending"];
                info = (string)jObject["info"];
                messageAllFields = (string)jObject["messageAllFields"];
                messageSendWithoutSubject = (string)jObject["messageSendWithoutSubject"];
                messageEmailSendingError = (string)jObject["messageEmailSendingError"];
                messageEmailSuccess = (string)jObject["messageEmailSuccess"];
                messageInvalidEmail = (string)jObject["messageInvalidEmail"];
                messageQuestion = (string)jObject["messageQuestion"];
                messageInformation = (string)jObject["messageInformation"];
                messageWarning = (string)jObject["messageWarning"];
                messageError = (string)jObject["messageError"];
            }
        }

        public void GetMainFormText()
        {
            if (File.Exists(languagePath))
            {
                JObject jObject = JObject.Parse(File.ReadAllText(languagePath));
                btnScreenshot = (string)jObject["btnScreenshot"];
                Settings = (string)jObject["Settings"];
                btnShowPictures = (string)jObject["btnShowPictures"];
                btnHidePictures = (string)jObject["btnHidePictures"];
                language = (string)jObject["language"];
                messageInvalidSelect = (string)jObject["messageInvalidSelect"];
                messageError = (string)jObject["messageError"];
            }
        }

        public void GetPictureFormText()
        {
            if (File.Exists(languagePath))
            {
                JObject jObject = JObject.Parse(File.ReadAllText(languagePath));
                btnBack = (string)jObject["btnBack"];
                btnSendAsEmail = (string)jObject["btnSendAsEmail"];
                Description = (string)jObject["Description"];
                defaultDescription = (string)jObject["defaultDescription"];
                messagePictureNotFound = (string)jObject["messagePictureNotFound"];
                messageError = (string)jObject["messageError"];
            }
        }

        public void GetSettingsFormText()
        {
            if (File.Exists(languagePath))
            {
                JObject jObject = JObject.Parse(File.ReadAllText(languagePath));
                btnBack = (string)jObject["btnBack"];
                Settings = (string)jObject["Settings"];
                FileName = (string)jObject["FileName"];
                StartNumber = (string)jObject["StartNumber"];
                SaveFolder = (string)jObject["SaveFolder"];
                btnBrowse = (string)jObject["btnBrowse"];
                DeleteAllFiles = (string)jObject["DeleteAllFiles"];
                rbYes = (string)jObject["rbYes"];
                rbNo = (string)jObject["rbNo"];
                secInTimer = (string)jObject["secInTimer"];
                settingFType = (string)jObject["settingFType"];
                FType = (string)jObject["FType"];
                Description = (string)jObject["Description"];
                rbEnable = (string)jObject["rbEnable"];
                rbDisable = (string)jObject["rbDisable"];
                SaveChanges = (string)jObject["SaveChanges"];
                messageAreYouSureToDelete = (string)jObject["messageAreYouSureToDelete"];
                messageAllFields = (string)jObject["messageAllFields"];
                messageChangesSaved = (string)jObject["messageChangesSaved"];
                messageUnsavedChanges = (string)jObject["messageUnsavedChanges"];
                messageWarning = (string)jObject["messageWarning"];
                messageQuestion = (string)jObject["messageQuestion"];
                messageInformation = (string)jObject["messageInformation"];
                SendEmailAfterScreenshot = (string)jObject["SendEmailAfterScreenshot"];
            }
        }
    }
}
