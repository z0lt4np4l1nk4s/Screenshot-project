using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt
{
    public partial class SettingsForm : Form
    {
        Settings settings = new Settings();
        LanguageClass language = new LanguageClass();
        EmailClass emailClass = new EmailClass();
        bool sIChanged = false;
        public SettingsForm()
        {
            InitializeComponent();
            language.GetSettingsFormText();
            language.GetEmailDialogText();
            LoadText();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lblSaveFolder.Text = fbd.SelectedPath + @"\";
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            numStartNumber.Minimum = 1;
            numStartNumber.Increment = 1;
            numSeconds.Minimum = 1;
            numSeconds.Increment = 1;
            cbType.Items.Add("JPEG (*.jpg)");
            cbType.Items.Add("BITMAP (*.bmp)");
            cbType.Items.Add("PNG (*.png)");
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSettingsFileType.Items.Add("JSON");
            cbSettingsFileType.Items.Add("XML");
            cbSettingsFileType.DropDownStyle = ComboBoxStyle.DropDownList;
            settings.GetJSONSettings();
            if (settings.settingsFileType == 1)
            {
                settings.GetXMLSettings();
            }
            emailClass.GetEmailDetails();
            LoadDetails();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            bool message = true;
            if (txtFileName.Text == "")
            {
                MessageBox.Show(language.messageAllFields, language.messageWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                message = false;
            }
            if (cbSendEmailAfterScreenshot.Checked && message)
            {
                if (txtFromEmail.Text != "" && txtPassword.Text != "" && txtToEmail.Text != "")
                {
                    MainForm.fromEmail = txtFromEmail.Text;
                    MainForm.password = txtPassword.Text;
                    MainForm.toEmail = txtToEmail.Text;
                    if (string.IsNullOrEmpty(txtSubject.Text))
                    {
                        MainForm.subject = "";
                    }
                    else
                    {
                        MainForm.subject = txtSubject.Text;
                    }
                    emailClass.SaveEmailDetails(txtFromEmail.Text, txtPassword.Text, txtToEmail.Text, txtSubject.Text);
                }
                else
                {
                    MessageBox.Show(language.messageAllFields, language.messageInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    message = false;
                }
            }
            if (rbNo.Checked && message)
            {
                MessageBox.Show(language.messageChangesSaved, language.messageInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveDetails();
            }
            if (rbYes.Checked)
            {
                if (MessageBox.Show(language.messageAreYouSureToDelete, language.messageWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show(language.messageChangesSaved, language.messageInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveDetails();
                    DirectoryInfo di = new DirectoryInfo(lblSaveFolder.Text);
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        fi.Delete();
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (cbSendEmailAfterScreenshot.Checked)
            {
                if (txtFromEmail.Text != "" && txtPassword.Text != "" && txtToEmail.Text != "")
                {
                    MainForm.fromEmail = txtFromEmail.Text;
                    MainForm.password = txtPassword.Text;
                    MainForm.toEmail = txtToEmail.Text;
                    if (string.IsNullOrEmpty(txtSubject.Text))
                    {
                        MainForm.subject = "";
                    }
                    else
                    {
                        MainForm.subject = txtSubject.Text;
                    }
                    emailClass.SaveEmailDetails(txtFromEmail.Text, txtPassword.Text, txtToEmail.Text, txtSubject.Text);
                    this.Hide();
                    MainForm.mainForm.Show();
                }
                else
                {
                    MessageBox.Show(language.messageAllFields, language.messageInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtFileName.Text != settings.fName || numStartNumber.Value != settings.numb || lblSaveFolder.Text != settings.path || rbYes.Checked != settings.check || numSeconds.Value != settings.seconds || cbType.SelectedIndex != settings.sIndex || rbDescEnable.Checked != settings.description || cbSettingsFileType.SelectedIndex != settings.settingsFileType || cbSendEmailAfterScreenshot.Checked != settings.sendEmailAfterScreenshot)
            {
                if (MessageBox.Show(language.messageUnsavedChanges, language.messageQuestion, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveDetails();
                    this.Hide();
                    MainForm.mainForm.Show();
                }
            }
            else
            {
                this.Hide();
                MainForm.mainForm.Show();
            }
            
            
        }
        
        private void SaveDetails()
        {
            settings.fName = txtFileName.Text;
            settings.numb = (int)numStartNumber.Value;
            settings.path = lblSaveFolder.Text;
            settings.check = rbYes.Checked;
            settings.seconds = (int)numSeconds.Value;
            settings.sIndex = cbType.SelectedIndex;
            settings.description = rbDescEnable.Checked;
            settings.settingsFileType = cbSettingsFileType.SelectedIndex;
            settings.sendEmailAfterScreenshot = cbSendEmailAfterScreenshot.Checked;
            if(settings.settingsFileType == 0)
            {
                settings.SetJSONSettings(settings);
            }
            else
            {
                settings.SetXMLSettings(settings);
            }
        }

        private void LoadDetails()
        {
            if (sIChanged)
            {
                if (settings.settingsFileType == 0)
                {
                    settings.GetJSONSettings();
                }
                else
                {
                    settings.GetXMLSettings();
                }
            }
            txtFileName.Text = settings.fName;
            numStartNumber.Value = settings.numb;
            lblSaveFolder.Text = settings.path;
            rbYes.Checked = settings.check;
            if (rbYes.Checked)
            {
                rbNo.Checked = false;
            }
            else
            {
                rbNo.Checked = true;
            }
            numSeconds.Value = settings.seconds;
            cbType.SelectedItem = cbType.Items[settings.sIndex];
            rbDescEnable.Checked = settings.description;
            if (rbDescEnable.Checked)
            {
                rbDescDisable.Checked = false;
            }
            else
            {
                rbDescDisable.Checked = true;
            }
            cbSettingsFileType.SelectedItem = cbSettingsFileType.Items[settings.settingsFileType];
            cbSendEmailAfterScreenshot.Checked = settings.sendEmailAfterScreenshot;
            txtFromEmail.Text = MainForm.fromEmail;
            txtPassword.Text = MainForm.password;
            txtToEmail.Text = MainForm.toEmail;
            txtSubject.Text = MainForm.subject;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbSettingsFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sIChanged)
            {
                settings.GetJSONSettings();
                settings.settingsFileType = cbSettingsFileType.SelectedIndex;
                settings.SetJSONSettings(settings);
                LoadDetails();
            }
            sIChanged = true;
        }

        private void cbSendEmailAfterScreenshot_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSendEmailAfterScreenshot.Checked)
            {
                gbEmail.Visible = true;
            }
            else
            {
                gbEmail.Visible = false;
            }
        }

        private void LoadText()
        {
            btnBack.Text = language.btnBack;
            lblSettings.Text = language.Settings;
            lblFileName.Text = language.FileName;
            lblStartNumber.Text = language.StartNumber;
            lblSaveF.Text = language.SaveFolder;
            btnBrowse.Text = language.btnBrowse;
            lblDeleteFiles.Text = language.DeleteAllFiles;
            rbYes.Text = language.rbYes;
            rbNo.Text = language.rbNo;
            lblSecTimer.Text = language.secInTimer;
            lblSetFType.Text = language.settingFType;
            lblFileType.Text = language.FType;
            lblDesc.Text = language.Description;
            rbDescEnable.Text = language.rbEnable;
            rbDescDisable.Text = language.rbDisable;
            btnSaveChanges.Text = language.SaveChanges;
            ToolTip.SetToolTip(lblInfo, language.info);
            lblYourEmail.Text = language.fromEmail;
            lblPassword.Text = language.password;
            lblTo.Text = language.toEmail;
            lblSubject.Text = language.subject;
            cbSendEmailAfterScreenshot.Text = language.SendEmailAfterScreenshot;
        }
    }
}
