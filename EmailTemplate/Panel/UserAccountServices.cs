﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailTemplate.Panel
{
    public partial class UserAccountServices : pnlSlider
    {
        public UserAccountServices(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        //================USER-ACCOUNT-SERVICES==================
        private void btnNetworkAccountBundle_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenNetworkAccountBundle();
        }
        private void btnNetworkAccountOnly_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenNetworkAccountOnly();

        }
        private void btnNetworkAccountSuspension_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenNetworkAccountSuspension();

        }
        //================USER-ACCOUNT-SERVICES==================

    }
}
