var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Swagger Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AddScoped<ICustomerService, CustomerService>();

var app = builder.Build();

// Swagger Middleware
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();
app.MapControllers();

app.Run();