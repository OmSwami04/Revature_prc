using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Assignment
    {
        
       public static void Main() {

            List<Customer> customers = new List<Customer> {
            new Customer{CustomerId = 1, CustomerName = "Om" },
            new Customer{CustomerId=2, CustomerName="Sushant"},
            new Customer{CustomerId=3,CustomerName="Mukund"}
            };

            List<Orders> orders = new List<Orders>
            {
                new Orders{OrderId=101,CustomerId=1,OrderAmount=500},
                new Orders { OrderId = 102, CustomerId = 1, OrderAmount = 1500 },
                new Orders { OrderId = 103, CustomerId = 2, OrderAmount = 700 },
                new Orders { OrderId = 104, CustomerId = 3, OrderAmount = 300 },
                new Orders { OrderId = 105, CustomerId = 2, OrderAmount = 1000 }
            };

            //LINQ JOIN
            var CustOrdDet = from c in customers
                             join o in orders
                           on c.CustomerId equals o.CustomerId
                             group o by new { c.CustomerId, c.CustomerName}
                           into g
                             select new
                             {
                                 CustomerId = g.Key.CustomerId,
                                 CustomerName = g.Key.CustomerName,
                                 OrderCount = g.Count(),
                                 TotalOrderValue = g.Sum(x => x.OrderAmount)
                             };
            foreach (var item in CustOrdDet)
            {
                Console.WriteLine($"Customer: {item.CustomerName}");
                Console.WriteLine($"Total Orders: {item.OrderCount}");
                Console.WriteLine($"Total Order Value: {item.TotalOrderValue}");
                Console.WriteLine("----------------------------");
            }

        }                      

    }
    public class Customer()
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
    public class Orders()
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal OrderAmount { get; set; }
    }
}
