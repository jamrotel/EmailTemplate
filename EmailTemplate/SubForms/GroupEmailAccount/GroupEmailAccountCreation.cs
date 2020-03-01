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
    public partial class GroupEmailAccountCreation : MetroFramework.Forms.MetroForm
    {
        public GroupEmailAccountCreation()
        {
            InitializeComponent();
       
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Outlook.Application application = new Outlook.Application();
            Outlook.MailItem mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - Audio Web Conferencing.oft") as Outlook.MailItem;
            mail.HTMLBody = mail.HTMLBody.Replace("RequestorName", ""+txtxRequestorFName.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("RecipientFirstName", ""+txtRecipientFirstName.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("TicketNumber", "" + txtHPSM.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("ComputerName", "" + txtComputerName.Text + "");
            mail.To = txtRequestorEmail.Text;
            mail.CC = txtRecipientEmail.Text;
            mail.Subject = txtHPSM.Text.ToString() + "- Audio Web Conferencing";
            mail.Attachments.Add(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Attachments\Test.txt");
            mail.Display(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        public void ClearText()
        {
            txtRequestorEmail.Text = "";
            txtRecipientFirstName.Clear();
            txtxRequestorFName.Clear();
            txtHPSM.Clear();
            txtComputerName.Clear();
        }


    }
}
