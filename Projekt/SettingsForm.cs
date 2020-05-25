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
        bool sIChanged = false;
        public SettingsForm()
        {
            InitializeComponent();
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
            cbSettingsFileType.Items.Add("JSON");
            cbSettingsFileType.Items.Add("XML");
            settings.GetJSONSettings();
            if (settings.settingsFileType == 1)
            {
                settings.GetXMLSettings();
            }
            LoadDetails();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != "")
            {
                if (rbYes.Checked)
                {
                    if (MessageBox.Show("Are you sure you want delete all files from selected folder?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        MessageBox.Show("Changes saved succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SaveDetails();
                        DirectoryInfo di = new DirectoryInfo(lblSaveFolder.Text);
                        foreach (FileInfo fi in di.GetFiles())
                        {
                            fi.Delete();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Changes saved succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveDetails();
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != settings.fName || numStartNumber.Value != settings.numb || lblSaveFolder.Text != settings.path || rbYes.Checked != settings.check || numSeconds.Value != settings.seconds || cbType.SelectedIndex != settings.sIndex || rbDescEnable.Checked != settings.description || cbSettingsFileType.SelectedIndex != settings.settingsFileType)
            {
                if (MessageBox.Show("You have some unsaved changes, do you want to save them?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveDetails();
                }
            }
            this.Hide();
            MainForm.mainForm.Show();
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
    }
}
