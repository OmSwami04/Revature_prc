using System.Data;
using MySql.Data.MySqlClient;
//conection
//command
//data tranfrer
namespace ADO
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //root @localhost:3306
            string conStr = "server=localhost;port=3306;user=root;password=\"Swamiom11@\";database=rev_prc1;";
          using MySqlConnection con=new MySqlConnection(conStr);
            try
            {
                con.Open();
                Console.WriteLine("Connected Successfully");
                MySqlCommand cmd = new MySqlCommand("SELECT id,age,name from student", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //int id=reader.GetInt32("id")(0);
                    // int age = reader.GetInt32("age");
                    // string name=reader.GetString("name");
                    int id = reader.GetInt32(0);
                    int age = reader.GetInt32(1);
                    string name = reader.GetString(2);

                    Console.WriteLine($"{id}\t{age}\t{name}");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
