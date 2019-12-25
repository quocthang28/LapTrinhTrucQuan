using Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Components
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Category(DataRow row)
        {
            ID = (int)row["id"];
            Name = row["name"].ToString();
        }

        public Category() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "SELECT * FROM dbo.FoodCategory";
            DataTable data = DP.DataProvider.ExeQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }
        public string GetCategoryNameByID(int id)
        {
            DataTable data = DP.DataProvider.ExeQuery("SELECT * FROM dbo.FoodCategory WHERE id = " + id);
            if (data.Rows.Count > 0)
            {
                Category c = new Category(data.Rows[0]);
                return c.Name;
            }
            return null;
        }

        public bool InsertCategory(string categoryName)
        {
            string query = "INSERT INTO dbo.FoodCategory (name) VALUES (N'" + categoryName + "')";
            int result = DP.DataProvider.ExeNonQuery(query);
            return result > 0;
        }

        public bool EditCategory(string categoryName, int cID)
        {
            string query = "UPDATE dbo.FoodCategory SET name = N'" + categoryName + "' WHERE id =" + cID;
            int result = DP.DataProvider.ExeNonQuery(query);
            return result > 0;
        }

        public bool DeleteCategory(int cID)
        {
            string query = "DELETE dbo.FoodCategory WHERE id = " + cID;
            int result = DP.DataProvider.ExeNonQuery(query);
            return result > 0;
        }
    }
}
