using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    class DP //DataProvider
    {
        private static DP dataProvider;
        public static DP DataProvider
        {
            get { if (dataProvider == null) dataProvider = new DP(); return DP.dataProvider; }
            private set { DP.dataProvider = value; }
        }

        private DP() { }

        private string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNH;Integrated Security=True";
        public DataTable ExeQuery(string query, object[] param = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                if (param != null)
                {
                    string[] paramList = query.Split(' ');
                    int i = 0;
                    foreach(string item in paramList)
                    {
                        if (item.Contains("@"))
                        {
                            com.Parameters.AddWithValue(item, paramList[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public int ExeNonQuery(string query, object[] param = null)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                if (param != null)
                {
                    string[] paramList = query.Split(' ');
                    int i = 0;
                    foreach (string item in paramList)
                    {
                        if (item.Contains("@"))
                        {
                            com.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = com.ExecuteNonQuery();

                con.Close();
            }
            return data;
        }
        public object ExeScarlar(string query, object[] param = null)
        {
            object data = 0;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                if (param != null)
                {
                    string[] paramList = query.Split(' ');
                    int i = 0;
                    foreach (string item in paramList)
                    {
                        if (item.Contains("@"))
                        {
                            com.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = com.ExecuteScalar();

                con.Close();
            }
            return data;
        }

    }
}

