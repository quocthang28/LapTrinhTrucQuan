using Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class fQuantityTable : Form
    {
        public SendNumOfTable send;
        public fQuantityTable()
        {
            InitializeComponent();
        }
        void SetTableQuanity()
        {
            string query = "DELETE dbo.BillInfo DELETE dbo.Bill DELETE dbo.TableFood DBCC CHECKIDENT('TableFood', RESEED, 0)";
            DP.DataProvider.ExeQuery(query);
            string query2 = "EXEC USP_AddTable @numOfTable";
            DP.DataProvider.ExeNonQuery(query2, new object[] { Convert.ToInt32(this.tbSoluong.Text) });
        }

        public fQuantityTable(SendNumOfTable sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(tbSoluong.Text, out parsedValue))
            { 
                MessageBox.Show("Nhập số");
                return;
            }
            else
            {
                SetTableQuanity();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                int parsedValue;
                if (!int.TryParse(tbSoluong.Text, out parsedValue))
                {
                    MessageBox.Show("Nhập số");
                    return;
                }
                else
                {
                    SetTableQuanity();
                    this.Close();
                }
            }
        }
    }
}
