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
    public partial class SharedDriveAccess : MetroFramework.Forms.MetroForm
    {
        public SharedDriveAccess()
        {
            InitializeComponent();
            cmbAccessType.Items.Insert(0, "Read Only");
            cmbAccessType.Items.Insert(1, "Read and Write");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Outlook.Application application = new Outlook.Application();
            Outlook.MailItem mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - Shared Drive Access.oft") as Outlook.MailItem;
            mail.HTMLBody = mail.HTMLBody.Replace("RequestorFirstName", ""+txtFirstName.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("RecipientFirstName", ""+txtRecipientFirstName.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("AccessType", "" + cmbAccessType.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("FolderPath", "" + txtFolderPath.Text + "");
            mail.To = txtEmailAddress.Text;
            mail.CC = txtRecipientEmail.Text;
            mail.Subject = txtTicketNumber.Text.ToString() + "- Shared Drive Access";
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
            txtRecipientFirstName.Clear();
            txtFirstName.Clear();
            txtTicketNumber.Clear();
        }


    }
}
