using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _service;

    public CustomerController(ICustomerService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCustomers()
    {
        var customers = await _service.GetAllCustomersAsync();
        return Ok(customers);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetCustomerById([FromQuery]int id)
    {
        var customer = await _service.GetCustomerByIdAsync(id);
        return Ok(customer);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomer([FromBody] CustomerDTO dto)
    {
        var result = await _service.CreateCustomerAsync(dto);

        return CreatedAtAction(nameof(GetCustomerById),
            new { id = result.Id }, result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateCustomer(int id, [FromBody] CustomerDTO dto)
    {
        var result = await _service.UpdateCustomerAsync(id, dto);
        return Ok(result);
    }

    [HttpPatch("{id:int}")]
    public async Task<IActionResult> PatchCustomer(int id, [FromBody] CustomerDTO dto)
    {
        var result = await _service.PatchCustomerAsync(id, dto);
        return Ok(result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCustomer(int id)
    {
        var result = await _service.DeleteCustomerAsync(id);

        if (!result)
            return NotFound();

        return NoContent();
    }
}