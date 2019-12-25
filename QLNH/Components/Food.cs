using Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Components
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public float Price { get; set; }
        public Food() { }

        public Food(DataRow row)
        {
            ID = (int)row["id"];
            Name = row["name"].ToString();
            CategoryID = (int)row["IDcategory"];
            Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        public List<Food> GetFoodBycategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM FOOD WHERE idCategory = " + id;
            DataTable data = DP.DataProvider.ExeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public bool InsertFood(string name, int id, float price)
        {
            string query = " INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'" + name + "', " + id + ", " + price + ")";
            int result = DP.DataProvider.ExeNonQuery(query);
            return result > 0;
        }

        public bool EditFood(int idFood, string name, int idCategory, float price)
        {
            string query = "UPDATE dbo.Food SET name = N'" + name + "', idCategory = " + idCategory + ", price = " + price + " WHERE id = " + idFood;
            int result = DP.DataProvider.ExeNonQuery(query);
            return result > 0;
        }

        public bool DeleteFood(int foodID)
        {
            BillInfo bi = new BillInfo();
            bi.DeleteBillInfoByFoodID(foodID);
            string query = "DELETE dbo.Food WHERE id = " + foodID;
            int result = DP.DataProvider.ExeNonQuery(query);
            return result > 0;
        }
    }
}
