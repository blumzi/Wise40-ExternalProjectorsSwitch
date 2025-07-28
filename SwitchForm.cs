using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalProjectorsSwitch
{
    public partial class SwitchForm : Form
    {
        SSRSwitch ssr;

        public SwitchForm(SSRSwitch ssr)
        {
            this.ssr = ssr;
            InitializeComponent();
        }

        private void onClick(object sender, EventArgs e)
        {
            if (sender == buttonOn)
            {
                buttonOn.Enabled = false;
                buttonOff.Enabled = true;
                this.ssr.Turn(SSRSwitch.On);
            }
            else if (sender == buttonOff)
            {
                buttonOn.Enabled = true;
                buttonOff.Enabled = false;
                this.ssr.Turn(SSRSwitch.Off);
            }
        }
    }
}
