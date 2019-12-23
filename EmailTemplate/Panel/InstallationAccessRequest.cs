using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Threading;
using EmailTemplate.Panel;

namespace EmailTemplate.Panel
{
    public partial class InstallationAccessRequest : pnlSlider
    {

        
        public InstallationAccessRequest(Form owner) : base(owner)
        {
            InitializeComponent();

        }
        
        //===============Installation-Accss-REQUEST===================
        private void btnSoftware_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenSoftInstallation();
        }
        
        private void btnElevatedAccess_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenElevatedAdmin();
        }

        private void btnVPNAccess_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenVPNRemoteAccessRequest();
        }

        private void btnRemoteAccessCitrix_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenRemoteAccessCitrix();
        }

        private void btnSharedFileFolderAccess_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenShareFileAccess();
        }
        private void btnSharedDriveAccess_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenSharedDriveAccess();
        }
        private void btnMSLyncAccountCreation_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenMSLyncAccount();
        }
        private void btnAudioWebConferencing_Click(object sender, EventArgs e)
        {
            EmailTemplate em =new EmailTemplate();
            em.OpenAudioWebConferencing();
        }
        //===============Installation-Accss-REQUEST===================
    }
}
