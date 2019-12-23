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
    public partial class MSLyncAccount : MetroFramework.Forms.MetroForm
    {
        public MSLyncAccount()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Outlook.Application application = new Outlook.Application();
            Outlook.MailItem mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - MS Lync Account Creation.oft") as Outlook.MailItem;
            mail.HTMLBody = mail.HTMLBody.Replace("RequestorName", "" + txtFirstName.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("TicketNumber", ""+ txtTicketNumber.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("EmailAddress", "" + txtEmailAddress.Text + "");
            mail.Subject = txtTicketNumber.Text.ToString() + "- MS Lync Account Creation";
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
            txtFirstName.Clear();
            txtTicketNumber.Clear();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoteAccessCitrix_Load(object sender, EventArgs e)
        {

        }
    }
}
