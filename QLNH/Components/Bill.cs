using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Components
{
    public class Bill
    {
        public int ID { get; set; }
        public DateTime? DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int Status { get; set; }
        public int Discount { get; set; }
     
        public Bill() { }
        public Bill(DataRow row)
        {
            ID = (int)row["id"];
            DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
            {
                DateCheckOut = (DateTime?)dateCheckOutTemp;
            }
            Status = (int)row["status"];
            Discount = (int)row["discount"];
        }
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DP.DataProvider.ExeQuery("SELECT * FROM BILL WHERE idTable = '" + id + "' AND status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void InsertBill(int id) // to table by table id
        {
            DP.DataProvider.ExeNonQuery("EXEC USP_InsertBill @idTable", new object[] { id });
        }
        public int GetLastIDBill() // lay id cua bill cuoi cung`
        {
            try
            {
                return (int)DP.DataProvider.ExeScarlar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void Checkout(int id, int discount,float totalPrice)
        {
            //var VND = CultureInfo.GetCultureInfo("vi-VN");
            //string tp = String.Format(VND,"{0:c}",totalPrice);
            
            string query = "UPDATE dbo.Bill SET DateCheckOut = GETDATE(), status = 1, totalPrice = " + totalPrice + " ,discount =" + discount + " WHERE id = " + id;
            DP.DataProvider.ExeNonQuery(query);
        }
    }
}
