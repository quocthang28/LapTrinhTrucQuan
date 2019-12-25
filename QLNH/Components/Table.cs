using Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class Table
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Table() { }

        public Table(DataRow row)
        {
            ID = (int)row["id"];
            Name = row["name"].ToString();
            Status = row["status"].ToString();
        }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DP.DataProvider.ExeQuery("SELECT * FROM dbo.TableFood");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
