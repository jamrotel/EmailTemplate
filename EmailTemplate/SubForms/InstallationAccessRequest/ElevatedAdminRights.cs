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
    public partial class ElevatedAdminRights : MetroFramework.Forms.MetroForm
    {
        public ElevatedAdminRights()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Outlook.Application application = new Outlook.Application();
            Outlook.MailItem mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - Elevated Workstation Privileges.oft") as Outlook.MailItem;
            mail.HTMLBody = mail.HTMLBody.Replace("Requestorsfirstname", ""+txtFirstName.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("AU-SDXXXX", ""+txtTicketNumber.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("SoftwareName ", ""+txtSoftwareName.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("SERVICEREQUESTNUMBER", ""+txtSCREQ.Text+"");
            mail.Subject = txtTicketNumber.Text.ToString() + ("- Elevated Workstation Privileges");
            mail.To = txtRequestorEmail.Text;
            //mail.Attachments.Add(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Attachments\Test.txt");
            mail.Display(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        public void ClearText()
        {
            txtSCREQ.Clear();
            txtFirstName.Clear();
            txtRequestorEmail.Clear();
            txtSoftwareName.Clear();
            txtTicketNumber.Clear();
        }
    }
}
