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

        List<dishes> dishesData;

        private DataSet loadDatatoDataset(string sqlCom)
        {
            string conStr = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\User\Desktop\專案資料\SanntouCafeReport\Database\revenueDB.mdb";
            OleDbConnection oledCon = new OleDbConnection(conStr);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCom, oledCon);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "test");
            oledCon.Close();
            oledCon.Dispose();
            return ds;
        }

        private List<string> loadMemberData()
        {
            DataSet ds = loadDatatoDataset(@"select * from staff");
            List<string> memberList = new List<string>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                memberList.Add(ds.Tables[0].Rows[i]["staffName"].ToString());
            return memberList;
        }

        private List<string> loadMenuGroup()
        {
            DataSet ds = loadDatatoDataset(@"select * from dishesGroup");
            List<string> memberList = new List<string>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                memberList.Add(ds.Tables[0].Rows[i]["groupName"].ToString());
            return memberList;
        }

        private void getDishesData()
        {
            DataSet ds = loadDatatoDataset(@"select * from dishesData, dishesGroup where dishesData.groupID = dishesGroup.groupID");
            List<string> memberList = new List<string>();
            string groupName, name;
            int orignPrice, costPrice;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                costPrice = Convert.ToInt32(ds.Tables[0].Rows[i]["costPrice"]);
                orignPrice = Convert.ToInt32(ds.Tables[0].Rows[i]["orignPrice"]);
                groupName = ds.Tables[0].Rows[i]["groupName"].ToString();
                name = ds.Tables[0].Rows[i]["dishesName"].ToString();
                dishesData.Add(new dishes(name, orignPrice, costPrice, groupName));
            }
        }

        private List<string> loadMenuName(string groupName)
        {
            List<string> menuData = new List<string>();

            foreach (dishes dish in dishesData)
            {
                if (dish._groupName == groupName)
                {
                    menuData.Add(dish._name);
                }
            }

            return menuData;

        }

        private void loadForm(object sender, EventArgs e)
        {
            dishesData = new List<dishes>();
            List<string> memberList = loadMemberData();
            List<string> menuGroupName = loadMenuGroup();

            getDishesData();
            cbDishGroup.Items.AddRange(menuGroupName.ToArray());
            cbReceptionist.Items.AddRange(memberList.ToArray());
        }

        private void cbDishGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDishName.Text = "";
            cbDishName.Enabled = true;
            List<string> menuData = loadMenuName(cbDishGroup.Text);
            cbDishName.Items.Clear();
            cbDishName.Items.AddRange(menuData.ToArray());
        }

        private void updateOrignPrice()
        {
            int totalPrice = Convert.ToInt32(tbOrignPrice.Text);
            string count, price;
            for (int i = 0; i < dgvOrderData.Rows.Count; i++)
            {
                count = dgvOrderData.Rows[i].Cells[2].Value.ToString();
                price = dgvOrderData.Rows[i].Cells[3].Value.ToString();
                totalPrice += Convert.ToInt32(count) * Convert.ToInt32(price);
            }
            tbOrignPrice.Text = totalPrice.ToString();
        }

        private void btWriteOrder_Click(object sender, EventArgs e)
        {
            string dishesName = cbDishName.Text;
            string orderTime = tpOrderTime.Text;
            int dishesCount = Convert.ToInt16(tbDishCount.Text);
            int orignPrice = 0;

            if (dishesCount == 0)
            {
                MessageBox.Show("餐點數量不可為0!");
                return;
            }
            if (dishesName.Trim() == "")
            {
                MessageBox.Show("請選擇餐點名稱!");
                return;
            }

            foreach (dishes dish in dishesData)
            {
                if (dish._name == dishesName)
                {
                    orignPrice = dish._orignPrice;
                    break;
                }

            }
            dgvOrderData.Rows.Add();
            dgvOrderData.Rows[dgvOrderData.Rows.Count - 1].Cells[0].Value = orderTime;
            dgvOrderData.Rows[dgvOrderData.Rows.Count - 1].Cells[1].Value = dishesName;
            dgvOrderData.Rows[dgvOrderData.Rows.Count - 1].Cells[2].Value = dishesCount;
            dgvOrderData.Rows[dgvOrderData.Rows.Count - 1].Cells[3].Value = orignPrice;
            updateOrignPrice();
        }

        private void dgvOrderData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateOrignPrice();
        }

        private void btSaveAll_Click(object sender, EventArgs e)
        {
            string customerName = tbCustomerName.Text;
            int customerCount = Convert.ToInt16(tbPeopleCount.Text);
            int realityPrice = Convert.ToInt16(tbRealityPrice.Text);
            string receptionist = cbReceptionist.Text;
            string idea = tbIdea.Text;
            

        }
    }
}
