using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCR
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btInputData_Click(object sender, EventArgs e)
        {
            formInputData formInputData = new formInputData();
            formInputData.Show();
        }

        private void btOutptReport_Click(object sender, EventArgs e)
        {
            formOutputReport formOutputReport = new formOutputReport();
            formOutputReport.Show();
        }
    }
}
