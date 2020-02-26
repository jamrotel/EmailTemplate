using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace EmailTemplate
{ 
    public partial class NetworkAccountBundle : MetroFramework.Forms.MetroForm
    {    
        Outlook.MailItem mail;
        public NetworkAccountBundle()
        {
            InitializeComponent();
            cmbAccessType.Items.Insert(0, "Read Only");
            cmbAccessType.Items.Insert(1, "Read and Write");

            int passwordLenght = 8;
            string valid = "abcdefghijklmnozABCDEFGHIJKLMNOZ1234567890";
            StringBuilder strB = new StringBuilder(100);
            Random random = new Random();

            while (0 < passwordLenght--)
            {
                strB.Append(valid[random.Next(valid.Length)]);
            }
            txtPassword.Text = strB.ToString();
        }

        //========================================================================================
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Outlook.Application application = new Outlook.Application();
            if (CBSharedDA.Checked && !CBLyncA.Checked)
            {
                mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - Network Account Creation - OnlySharedDrive.oft") as Outlook.MailItem;
            }
            else if (!CBSharedDA.Checked && CBLyncA.Checked)
            {
                mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - Network Account Creation - OnlyLync.oft") as Outlook.MailItem;
            }
            else if (CBSharedDA.Checked && CBLyncA.Checked)
            {
                mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - Network Account Creation.oft") as Outlook.MailItem;
            }
            else if (!CBSharedDA.Checked && !CBLyncA.Checked)
            {
                mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - Network Account Creation - NoLyncAndSharedDrive.oft") as Outlook.MailItem;
            }
            
          
            mail.HTMLBody = mail.HTMLBody.Replace("RequestorName", ""+txtFirstName.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("TicketNumber", "" + txtTicketNumber.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("RecipientEmail", "" + txtRecipientEmail.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("UsernameDetails", ""+ txtusername.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("PasswordDetails", "" + txtPassword.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("AccessType", "" + cmbAccessType.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("FolderPath", "" + txtFolderPath.Text + "");
            
            mail.To = txtEmailAddress.Text;
            mail.CC = txtRecipientEmail.Text;
            mail.Subject = txtTicketNumber.Text.ToString() + "- Network Account Creation";
            //mail.Attachments.Add(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Attachments\Test.txt");
            mail.Display(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();

            int passwordLenght = 8;
            string valid = "abcdefghijklmnozABCDEFGHIJKLMNOZ1234567890";
            StringBuilder strB = new StringBuilder(100);
            Random random = new Random();

            while (0 < passwordLenght--)
            {
                strB.Append(valid[random.Next(valid.Length)]);
            }
            txtPassword.Text = strB.ToString();
        }

        public void ClearText()
        {
            txtEmailAddress.Text = "";
            txtRecipientFirstName.Clear();
            txtFirstName.Clear();
            txtTicketNumber.Clear();
            txtLyncAccess.Clear();
            txtusername.Clear();
            txtFolderPath.Clear();
            txtRecipientEmail.Clear();
        }

    }
}
