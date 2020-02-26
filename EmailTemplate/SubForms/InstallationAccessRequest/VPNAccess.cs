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
    public partial class VPNAccess : MetroFramework.Forms.MetroForm
    {
        public VPNAccess()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Outlook.Application application = new Outlook.Application();
            Outlook.MailItem mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - VPN Remote Access Request.oft") as Outlook.MailItem;
            mail.HTMLBody = mail.HTMLBody.Replace("SERVICEREQUESTNUMBER", ""+txtSCREQ.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("Requestorsfirstname", ""+txtFirstName.Text+"");   
            mail.Subject = txtTicketNumber.Text.ToString() + "- VPN Remote Access Request";
            mail.To = txtEmailAddress.Text;
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
            txtSCREQ.Clear();
            txtFirstName.Clear();
            txtTicketNumber.Clear();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
