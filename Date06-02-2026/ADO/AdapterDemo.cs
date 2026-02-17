using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    /*
     * da.Fill(ds);

Opens connection

Fetches data

Stores in DataSet

Closes connection automatically
     */
    public class AdapterDemo
    {
        public static void Main()
        {
            string conStr ="server=localhost;user=root;password=\"Swamiom11@\";database=productDb;";
            using(MySqlConnection con = new MySqlConnection(conStr))
            {
                string query = "Select * from product_info ";

                MySqlDataAdapter da = new MySqlDataAdapter(query,con);

                DataSet ds = new DataSet();
                da.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                { 
                    Console.WriteLine(
                   row["id"] + " " +
                   row["name"] + " " +
                   row["tagline"] + " " +
                   row["price"]);
                }
            }
        }
    }
}
