using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Components;
namespace QLNH
{
    public partial class fDoanhThu : Form
    {
        public fDoanhThu()
        {
            InitializeComponent();
            setDate();
        }
        void setDate()
        {
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
        }

        private void btnThongKe_Click(object sender, EventArgs e)// thống kê
        {
            string startDay = dateTimePicker1.Value.ToString("yyyy-MM-dd 00:00:00");
            string endDay = dateTimePicker2.Value.ToString("yyyy-MM-dd 23:59:59");
            string query = "SELECT tf.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Thời gian CheckIn], DateCheckOut AS [Thời gian CheckOut]  FROM dbo.Bill AS b, dbo.TableFood AS tf WHERE DateCheckIn >= '" + startDay + "' AND DateCheckOut <= '" + endDay + "' AND b.status = 1 AND tf.id = b.idTable";
            dgvBill.DataSource = DP.DataProvider.ExeQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)// thống kê
        {
            string startDay = dateTimePicker1.Value.ToString("yyyy-MM-dd 00:00:00");
            string endDay = dateTimePicker2.Value.ToString("yyyy-MM-dd 23:59:59");
            string query = "SELECT tf.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Thời gian CheckIn], DateCheckOut AS [Thời gian CheckOut]  FROM dbo.Bill AS b, dbo.TableFood AS tf WHERE DateCheckIn >= '" + startDay + "' AND DateCheckOut <= '" + endDay + "' AND b.status = 1 AND tf.id = b.idTable";
            dgvBill.DataSource = DP.DataProvider.ExeQuery(query);
        }
    }
}
