using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SCR
{
    public partial class FormInputOrder : Form
    {
        public FormInputOrder()
        {
            InitializeComponent();
        }

        private void loadForm(object sender, EventArgs e)
        {
            string conStr = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\User\Desktop\專案資料\SanntouCafeReport\Database\test.mdb";
            string searchStr = @"select * from memberData";
            OleDbConnection oledCon = new OleDbConnection(conStr);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(searchStr, oledCon);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "test");

            List<string> test = new List<string>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                test.Add(ds.Tables[0].Rows[i]["memberName"].ToString());

            cbReceptionist.Items.AddRange(test.ToArray());
            oledCon.Close();
            oledCon.Dispose();
        }
    }
}
