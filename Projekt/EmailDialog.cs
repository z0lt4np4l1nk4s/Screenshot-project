﻿using System;
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
        public EmailDialog()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[a-z0-9_\-\.]{3,20}@[a-z]{1,10}.[a-z]{2,4}$");
            if (txtFromEmail.Text == "" || txtPassword.Text == "" || txtToEmail.Text == "")
            {
                MessageBox.Show("All fields must be filled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rx.IsMatch(txtFromEmail.Text) && rx.IsMatch(txtToEmail.Text))
                {
                    if (CheckIfEverythingIsOK())
                    {
                        btnSend.Text = "Sending...";
                        btnSend.Enabled = false;
                        btnSend.Refresh();
                        EmailClass.SendEmail(txtFromEmail.Text, txtPassword.Text, txtToEmail.Text, txtSubject.Text);
                        btnSend.Text = "Send";
                        btnSend.Enabled = true;
                        pictureForm.Activate();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email adress!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("All fields must be filled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtSubject.Text == "")
            {
                if (MessageBox.Show("Are you sure that you want to send the email without a subject?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtSubject.Text = PictureForm.picName;
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