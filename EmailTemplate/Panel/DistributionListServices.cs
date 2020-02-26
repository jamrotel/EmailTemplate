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
    public partial class DistributionListServices : pnlSlider
    {
        public DistributionListServices (Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void DistributionListServices_Load(object sender, EventArgs e)
        {

        }
    }
}
