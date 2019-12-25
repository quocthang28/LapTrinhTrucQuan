using QLNH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{ 
    public class Account
    {
        private static Account acc;
        public Account() { }
        public static Account Acc
        {
            get { if (acc == null) acc = new Account(); return acc; }
            private set { acc = value; }
        }
        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + username + "' AND Password = '" + password + "'";
            DataTable result = DP.DataProvider.ExeQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
