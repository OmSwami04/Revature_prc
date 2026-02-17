using System;
using MySql.Data.MySqlClient;

namespace ADO
{
    public class Sprac1
    {
        public static void Main()
        {
            string conStr =
            "server=localhost;port=3306;user=root;password=\"Swamiom11@\";database=rev_prc1;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conStr))
                {
                    con.Open();
                    Console.WriteLine("Database Connected Successfully");

                    using (MySqlCommand cmd =
                        new MySqlCommand("SELECT * FROM student", con))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Console.WriteLine(
                                    dr["id"].ToString() + " " +
                                    dr["name"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}