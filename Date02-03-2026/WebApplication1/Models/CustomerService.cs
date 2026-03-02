namespace WebApiDemo.Models
{
    public class CustomerService : ICustomerService
    {
        private readonly CrmDbContext dbContext;

        public CustomerService(CrmDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return dbContext.Customers.ToList();
        }
    }
}