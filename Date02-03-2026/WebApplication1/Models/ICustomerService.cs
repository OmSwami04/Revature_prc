namespace WebApiDemo.Models
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
    }
}