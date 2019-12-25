using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Components;
using QLNH;
using QLNH.Components;

namespace Components
{
    public delegate void SendCount(int value);
    public delegate void SendNumOfTable(int value);
    public partial class fTableManager : Form
    {

        /// <summary>
        /// Biến
        /// </summary>
        Menu menu = new Menu();
        Category category = new Category();
        Table table = new Table();
        Food food = new Food();
        Bill bill = new Bill();
        BillInfo billinfo = new BillInfo();

        public int foodCount;
        public int tableCount;

        public fTableManager()
        {                                                                            
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }


        #region Methods

        void LoadCategory()
        {
            List<Category> listCategory = category.GetListCategory();
            foreach (Category c in listCategory)
            {
                Button btnCategory = new Button() { Width = 250, Height = 100 };
                btnCategory.Text = c.Name;
                btnCategory.BackColor = Color.White;
                btnCategory.ForeColor = Color.Black;
                btnCategory.Font = new Font("Arial", 16, FontStyle.Bold);
                flowLayoutPanel1.Controls.Add(btnCategory);
                btnCategory.Click += (sender, EventArgs) => { BtnCategory_Click(sender, EventArgs, c.ID); };
            }
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = table.LoadTableList();
            foreach(Table item in tableList)
            {
                Button btn = new Button() { Width = 130, Height = 150 };
                btn.Tag = item;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.LightBlue;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                if (item.Status == "Còn trống" || item.Status == "Còn Trống")
                {
                    btn.ForeColor = Color.Green;
                }
                else if (item.Status == "Có người")
                {
                    btn.ForeColor = Color.Red;
                }
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            float totalPrice = 0;
            var VND = CultureInfo.GetCultureInfo("vi-VN");
            lvBill.Items.Clear();
            lvBill.Font = new Font("Arial", 12);

            List<Menu> listBillInfo = menu.GetListMenuByTable(id);
            foreach(Menu item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.FoodName.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.totalPrice.ToString());
                totalPrice += item.totalPrice;
                lvBill.Items.Add(lvItem);
            }
            tbtotalPrice.Text = String.Format(VND, "{0:c}", totalPrice);

        }

        private void SetValue(int value) // food 
        {
            this.foodCount = value;
        }

        private void SetTableQuantity(int value) // table
        {
            this.tableCount = value;
        }

        #endregion


        #region Events

        private void Btn_Click(object sender, EventArgs e) // table button
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            label2.Text = "Bàn " + (tableID).ToString();
        }

        private void BtnCategory_Click(object sender, EventArgs e, int cID)
        {
            flowLayoutPanel2.Controls.Clear();
            List<Food> listFood = food.GetFoodBycategoryID(cID);
            flowLayoutPanel2.Controls.Clear();
            foreach (Food f in listFood)
            {
                Button foodButton = new Button() { Width = 320, Height = 100 };
                foodButton.Tag = f;
                foodButton.Text = f.Name;
                foodButton.BackColor = Color.White;
                foodButton.ForeColor = Color.Black;
                foodButton.Font = new Font("Arial", 16, FontStyle.Bold);
                flowLayoutPanel2.Controls.Add(foodButton);
                foodButton.Click += FoodButton_Click;
            }
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Chọn bàn");
            }
            else
            {
                fQuantityFood f = new fQuantityFood(SetValue);
                f.ShowDialog();
                int count = foodCount;
                int idBill = bill.GetUncheckBillIDByTableID(table.ID);
                int foodID = ((sender as Button).Tag as Food).ID;
                //int foodcount = (int)nmQuantity.Value;

                if (idBill == -1)
                {
                    bill.InsertBill(table.ID);
                    billinfo.InsertBillInfo(bill.GetLastIDBill(), foodID, count);
                }
                else
                {
                    billinfo.InsertBillInfo(idBill, foodID, count);
                }
                ShowBill(table.ID);
                LoadTable();
            }

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            int idBill = bill.GetUncheckBillIDByTableID(table.ID);
            double totalPrice = double.Parse(tbtotalPrice.Text,NumberStyles.Currency,CultureInfo.GetCultureInfo("vi-VN"));
            int discount = (int)nmDiscount.Value;
            double finalPrice = double.Parse((totalPrice - totalPrice * discount / 100).ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"));
            tbFinalPrice.Text = finalPrice.ToString();
            if (idBill != -1)
            {
                if (MessageBox.Show("Click OK để xác nhận thanh toán hóa đơn cho " + table.Name, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bill.Checkout(idBill, discount, (float)totalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                    nmDiscount.Value = 0;
                    tbFinalPrice.Text = "0";
                }
            }
        }
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            fDoanhThu f = new fDoanhThu();
            f.ShowDialog();

        }

        private void btnQuanLyThucDon_Click(object sender, EventArgs e)
        {
            fEditMenu f = new fEditMenu();
            f.ShowDialog();
        }

        private void btnThayDoiSLBan_Click(object sender, EventArgs e) // change table
        {
               fQuantityTable f = new fQuantityTable();
               f.ShowDialog();
     
        }

        private void btnRefeshTable_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            double totalPrice = double.Parse(tbtotalPrice.Text.Split(',')[0]);
            int discount = (int)nmDiscount.Value;
            double finalPrice = totalPrice - totalPrice * discount / 100;
            tbFinalPrice.Text = finalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadCategory();
        }

        #endregion



    }
}
