using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace Projekt
{
    public partial class EmailDialog : Form
    {
        PictureForm pictureForm = new PictureForm();
        LanguageClass language = new LanguageClass();
        EmailClass email = new EmailClass();
        public EmailDialog()
        {
            InitializeComponent();
            language.GetEmailDialogText();
            toolTip.SetToolTip(lblInfo, language.info);
            lblYourEmail.Text = language.fromEmail;
            lblPassword.Text = language.password;
            lblTo.Text = language.toEmail;
            lblSubject.Text = language.subject;
            lblYourEmail.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[a-z0-9_\-\.]{3,20}@[a-z]{1,10}.[a-z]{2,4}$");
            if (txtFromEmail.Text == "" || txtPassword.Text == "" || txtToEmail.Text == "")
            {
                MessageBox.Show(language.messageAllFields, language.messageInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rx.IsMatch(txtFromEmail.Text) && rx.IsMatch(txtToEmail.Text))
                {
                    if (CheckIfEverythingIsOK())
                    {
                        btnSend.Text = language.btnSending;
                        btnSend.Enabled = false;
                        btnSend.Refresh();
                        email.SendEmail(txtFromEmail.Text, txtPassword.Text, txtToEmail.Text, txtSubject.Text);
                        btnSend.Text = language.btnSend;
                        btnSend.Enabled = true;
                        pictureForm.Activate();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(language.messageInvalidEmail, language.messageWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = "";
                }
            }
        }

        private void txtFromEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (CheckIfEverythingIsOK())
                {
                    btnSend_Click(sender, e);
                }
            }
        }

        private bool CheckIfEverythingIsOK()
        {
            if (txtFromEmail.Text == "" || txtPassword.Text == "" || txtToEmail.Text == "")
            {
                MessageBox.Show(language.messageAllFields, language.messageInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtSubject.Text == "")
            {
                if (MessageBox.Show(language.messageSendWithoutSubject, language.messageQuestion, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtSubject.Text = EmailClass.picName;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (CheckIfEverythingIsOK())
                {
                    btnSend_Click(sender, e);
                }
            }
        }

        private void txtToEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (CheckIfEverythingIsOK())
                {
                    btnSend_Click(sender, e);
                }
            }
        }

        private void txtSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (CheckIfEverythingIsOK())
                {
                    btnSend_Click(sender, e);
                }
            }
        }

        private void EmailDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureForm.Activate();
        }
    }
}
