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
    public partial class EmployeeNetworkEmailReactivation : MetroFramework.Forms.MetroForm
    {    
        Outlook.MailItem mail;
        public EmployeeNetworkEmailReactivation()
        {
            InitializeComponent();

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
           
                mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - Employee Account and Email Reactivation.oft") as Outlook.MailItem;
          
            
          
            mail.HTMLBody = mail.HTMLBody.Replace("RequestorName", ""+txtFirstName.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("TicketNumber", "" + txtTicketNumber.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("UsernameDetails", ""+ txtusername.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("PasswordDetails", "" + txtPassword.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("EmailDetails", "" + txtRecipientFirstName.Text + "");

            mail.To = txtEmailAddress.Text;
            //mail.CC = txtRecipientEmail.Text;
            mail.Subject = txtTicketNumber.Text.ToString() + "- Employee Account and Email Reactivation";
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
            txtusername.Clear();
           
        }

     
    }
}
