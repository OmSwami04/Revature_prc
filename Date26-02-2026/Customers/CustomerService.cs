public interface ICustomerService
{
    Task<List<CustomerDTO>> GetAllCustomersAsync();
    Task<CustomerDTO> GetCustomerByIdAsync(int id);
    Task<CustomerDTO> CreateCustomerAsync(CustomerDTO dto);
    Task<CustomerDTO> UpdateCustomerAsync(int id, CustomerDTO dto);
    Task<CustomerDTO> PatchCustomerAsync(int id, CustomerDTO dto);
    Task<bool> DeleteCustomerAsync(int id);
}

public class CustomerService : ICustomerService
{
    private readonly ILogger<CustomerService> _logger;

    // TEMP MEMORY DATABASE
    private static List<CustomerDTO> _customers = new();

    public CustomerService(ILogger<CustomerService> logger)
    {
        _logger = logger;
    }

    public async Task<List<CustomerDTO>> GetAllCustomersAsync()
    {
        return _customers;
    }

    public async Task<CustomerDTO> GetCustomerByIdAsync(int id)
    {
        return _customers.FirstOrDefault(c => c.Id == id);
    }

    public async Task<CustomerDTO> CreateCustomerAsync(CustomerDTO dto)
    {
        dto.Id = _customers.Count + 1;
        _customers.Add(dto);
        return dto;
    }

    public async Task<CustomerDTO> UpdateCustomerAsync(int id, CustomerDTO dto)
    {
        var customer = _customers.FirstOrDefault(c => c.Id == id);
        if (customer == null) return null;

        customer.Name = dto.Name;
        customer.Email = dto.Email;
        return customer;
    }

    public async Task<CustomerDTO> PatchCustomerAsync(int id, CustomerDTO dto)
    {
        var customer = _customers.FirstOrDefault(c => c.Id == id);
        if (customer == null) return null;

        if (!string.IsNullOrEmpty(dto.Name))
            customer.Name = dto.Name;

        if (!string.IsNullOrEmpty(dto.Email))
            customer.Email = dto.Email;

        return customer;
    }

    public async Task<bool> DeleteCustomerAsync(int id)
    {
        var customer = _customers.FirstOrDefault(c => c.Id == id);
        if (customer == null) return false;

        _customers.Remove(customer);
        return true;
    }
}

public class CustomerDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
}