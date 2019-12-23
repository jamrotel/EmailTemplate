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
    public partial class ShareFileAccess : MetroFramework.Forms.MetroForm
    {
        public ShareFileAccess()
        {
            InitializeComponent();
  

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Outlook.Application application = new Outlook.Application();
            Outlook.MailItem mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Access\AU-SDXXXX - ShareFile Access And Installation.oft") as Outlook.MailItem;
            mail.HTMLBody = mail.HTMLBody.Replace("AU-SDXXXX", "" + txtTicketNumber.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("Requestorname", ""+txtFirstName.Text+"");   
            mail.HTMLBody = mail.HTMLBody.Replace("ComputerName", ""+txtCompName.Text+"");
            mail.Subject = txtTicketNumber.Text.ToString() + "- ShareFile Access & Installation";
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
            
            txtCompName.Clear();
            txtFirstName.Clear();
            txtRequestorEmail.Clear();
            txtTicketNumber.Clear();
        }

        // Load event not working
        private void SoftwareInstallation_Load(object sender, EventArgs e)
        {
            //    string[] softwarelist = {"Adobe Acrobat Pro DC", "Microsoft Office Access 2010", "Microsoft Project Online", "Microsoft Visio Standard", "Microsoft Visio Online" };
            //    cmbSoftwareName.Items.AddRange(softwarelist);
            //cmbSoftwareName.Items.Insert(0,"Adobe Acrobat Pro DC");
            //cmbSoftwareName.Items.Insert(1,"Microsoft Office Access 2010");
            //cmbSoftwareName.Items.Insert(2,"Microsoft Project Online");
            //cmbSoftwareName.Items.Insert(3,"Microsoft Visio Standard");
            //cmbSoftwareName.Items.Insert(4,"Microsoft Visio Online");

        }

    }
}
