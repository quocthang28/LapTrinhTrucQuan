using Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class BillInfo
    {
        public int ID { get; set; }
        public int billID { get; set; }
        public int foodID { get; set; }
        public int count { get; set; }
        public BillInfo() { }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.billID = (int)row["idbill"];
            this.foodID = (int)row["idfood"];
            this.count = (int)row["count"];
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DP.DataProvider.ExeQuery("SELECT * FROM  dbo.BillInfo WHERE idBill = '" + id + "'");

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DP.DataProvider.ExeNonQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
        public void DeleteBillInfoByFoodID(int id)
        {
            DP.DataProvider.ExeQuery("DELETE dbo.BillInfo WHERE idFood = " + id);
        }
    }
}
