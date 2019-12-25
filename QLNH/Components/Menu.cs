using Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class Menu
    {
        public string FoodName { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public float totalPrice { get; set; }


        public Menu() { }

        public Menu(DataRow row)
        {
            FoodName = row["Name"].ToString();
            Count = (int)row["count"];
            Price = (float)Convert.ToDouble(row["price"].ToString());
            totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
            //finalPrice = (float)Convert.ToDouble(row["finalPrice"].ToString());
        }

        public List<Menu> GetListMenuByTable(int id) //show bill cua tung` ban`
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.name,bi.count,f.price,f.price*bi.count AS totalPrice FROM  dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " + id;

            DataTable data = DP.DataProvider.ExeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
