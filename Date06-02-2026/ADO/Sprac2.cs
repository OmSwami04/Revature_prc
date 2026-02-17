using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ADO
{
    public class Sprac2
    {
        public static void Main()
        {
            string s1 = "server=localhost;user=root;password=\"Swamiom11@\";database=productDb";
            try
            {
                using (MySqlConnection con = new MySqlConnection(s1))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("Select * from product_info", con))
                    {
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                //Console.WriteLine(rd["id"].ToString());
                                //Console.WriteLine(rd["name"].ToString());
                                //Console.WriteLine(rd["tagline"].ToString());
                                //Console.WriteLine(rd["price"].ToString());
                                Console.WriteLine($"{rd["id"]} {rd["name"]} {rd["tagline"]} {rd["price"]}");


                            }
                        }
                    }
                }
            }
            catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
