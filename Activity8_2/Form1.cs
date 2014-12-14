using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity8_2
{
    public partial class txtLogger : Form
    {
        private void btnLogInfo_Click(object sender, EventArgs e)
        {
            this.Text = Logger.LogWrite(txtLogPath.Text, txtLogInfo.Text);
        }
        public txtLogger()
        {
            InitializeComponent();
        }

        private void btmLogInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
