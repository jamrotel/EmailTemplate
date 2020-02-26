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
    public partial class NetworkAccountSuspension : MetroFramework.Forms.MetroForm
    {    
        Outlook.MailItem mail;
        public NetworkAccountSuspension()
        {
            InitializeComponent();

        }

        //========================================================================================
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Outlook.Application application = new Outlook.Application();
           
                mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - Network Account Suspension.oft") as Outlook.MailItem;
          
            
          
            mail.HTMLBody = mail.HTMLBody.Replace("RequestorName", ""+txtFirstName.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("TicketNumber", "" + txtTicketNumber.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("UsernameDetails", ""+ txtusername.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("Date", "" + txtdate.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("RecipientEmail", "" + txtRecipientEmail.Text + "");
            mail.To = txtEmailAddress.Text;
            //mail.CC = txtRecipientEmail.Text;
            mail.Subject = txtTicketNumber.Text.ToString() + "- Network Account Creation";
            //mail.Attachments.Add(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Attachments\Test.txt");
            mail.Display(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();

        }

        public void ClearText()
        {
            txtEmailAddress.Text = "";
            txtRecipientEmail.Clear();
            txtFirstName.Clear();
            txtTicketNumber.Clear();   
            txtusername.Clear();
            
        }

      
    }
}
