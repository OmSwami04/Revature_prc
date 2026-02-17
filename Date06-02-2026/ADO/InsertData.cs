using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ADO
{
    public class InsertData
    {
        public static void Main()
        {
            string conStr = "server=localhost;port=3306;user=root;password=\"Swamiom11@\";database=rev_prc1;";
            try
            {
                using (MySqlConnection con = new MySqlConnection(conStr))
                {
                    con.Open();
                    Console.WriteLine("db ddon");
                    string query = "Insert into student(id,name,age)values(@id,@name,@age)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", 606);
                        cmd.Parameters.AddWithValue("@name", "Sharad");
                        cmd.Parameters.AddWithValue("@age", 88);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            Console.WriteLine("data added");
                        }
                        else
                        {
                            Console.WriteLine("failed");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.ToString());
            }
        }
    }
}
