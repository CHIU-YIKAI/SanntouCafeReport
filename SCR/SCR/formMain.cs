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
            FormInputOrder formInputOrder = new FormInputOrder();
            formInputOrder.Show();
        }

        private void btOutptReport_Click(object sender, EventArgs e)
        {
            formOutputReport formOutputReport = new formOutputReport();
            formOutputReport.Show();
        }

        private void btDataSetting_Click(object sender, EventArgs e)
        {
            formDataSetting formDataSetting = new formDataSetting();
            formDataSetting.Show();
        }

        private void btExpensesData_Click(object sender, EventArgs e)
        {
            formExpenses formExpenses = new formExpenses();
            formExpenses.Show();
        }
    }
}
