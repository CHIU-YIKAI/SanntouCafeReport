using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCR
{
    public partial class formDataSetting : Form
    {
        public formDataSetting()
        {
            InitializeComponent();
        }

        private void getAccessDatasetData()
        {
            int chouseCount = cbList.SelectedIndex;
            string[] chouseName = { "staff", "dishesGroup", "dishesData" };

            string conStr = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\User\Desktop\專案資料\SanntouCafeReport\Database\revenueDB.mdb";
            string searchStr = @"select * from " + chouseName[chouseCount];
            OleDbConnection oledCon = new OleDbConnection(conStr);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(searchStr, oledCon);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "test");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            oledCon.Close();
            oledCon.Dispose();

        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAccessDatasetData();
        }
    }
}
