using CustomerApp.Models;
using CustomerApp.DTOs;

public class CustomerService : ICustomerService
{
    public List<CustomerResponseDTO> GetAllCustomers()
    {
        List<Customer> cx = new List<Customer>()
        {
            new Customer{FirstName="Om",LastName="Swami",Email="om@gmail.com",Password="123"},
            new Customer{FirstName="Raj",LastName="Patil",Email="raj@gmail.com",Password="456"}
        };

        var result = from c in cx
                     select new CustomerResponseDTO
                     {
                         FullName = c.FirstName + " " + c.LastName,
                         Email = c.Email
                     };

        return result.ToList();
    }
}