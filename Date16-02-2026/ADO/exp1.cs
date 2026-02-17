//using System;
//using System.Data.SqlClient;

//namespace AdoDotnetDemo
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var connectionString = "Data Source=localhost;Initial Catalog=CrmDb;password=p@ssw0rd;User ID=ziaullah;TrustServerCertificate=True";

//            // for disposing connection object
//            //using (var connection = new SqlConnection(connectionString))
//            //{
//            //}

//            using var connection = new SqlConnection(connectionString);

//            try
//            {
//                connection.Open();
//                Console.WriteLine("Connection opened successfully.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//                return;
//            }
//            finally
//            {
//                connection.Close();
//            }
//        }
//    }
//}