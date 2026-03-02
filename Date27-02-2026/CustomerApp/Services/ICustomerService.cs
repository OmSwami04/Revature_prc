using CustomerApp.DTOs;

public interface ICustomerService
{
    List<CustomerResponseDTO> GetAllCustomers();
}