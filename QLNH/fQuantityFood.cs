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
    public partial class fQuantityFood : Form
    {
        public SendCount send;
        public fQuantityFood()
        {
            InitializeComponent();
        }

        public fQuantityFood(SendCount sender)
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
                this.send(Convert.ToInt32(this.tbSoluong.Text));
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                int parsedValue;
                if (!int.TryParse(tbSoluong.Text, out parsedValue))
                {
                    MessageBox.Show("Nhập số");
                    return;
                }
                else
                {
                    this.send(Convert.ToInt32(this.tbSoluong.Text));
                    this.Close();
                }
            }
        }
    }
}
