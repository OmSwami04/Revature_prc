using System;
using System.Collections.Generic;

namespace Day_07
{
    public class OrderProcessor
    {
        // Product catalog (SKU → Price)
        private readonly Dictionary<string, decimal> _catlog = new()
        {
            ["SKU-100"] = 29.99m,
            ["SKU-200"] = 49.99m,
            ["SKU-300"] = 99.99m,
        };

        // List to store saved orders
        private readonly List<Order> _savedOrders = new();

        // Public method to process order
        public void Process(string sku, int quantity)
        {
            try
            {
                var order = CreateOrder(sku, quantity);
                Save(order);

                Console.WriteLine($"Saved order: {order.Sku}, qty {order.Quantity}, total {order.Total}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to process order: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Process :: Inside Finally");
            }
        }

        // Create order after validation and price lookup
        private Order CreateOrder(string sku, int quantity)
        {
            try
            {
                Validate(sku, quantity);

                var price = LookupPrice(sku);

                return new Order(sku, quantity, price * quantity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating order: {ex.Message}");
                throw; // rethrow to Process()
            }
            finally
            {
                Console.WriteLine("CreateOrder :: Inside Finally");
            }
        }

        // Validate input
        private void Validate(string sku, int quantity)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sku))
                    throw new ArgumentException("SKU is required");

                if (quantity <= 0)
                    throw new ArgumentException("Quantity must be positive");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Validation failed: {ex.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("Validate :: Inside Finally");
            }
        }

        // Lookup price from dictionary
        private decimal LookupPrice(string sku)
        {
            try
            {
                if (!_catlog.TryGetValue(sku, out var price))
                    throw new KeyNotFoundException($"Unknown SKU: {sku}");

                return price;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("LookupPrice :: Inside Finally");
            }
        }

        // Save order (simulating DB save)
        private void Save(Order order)
        {
            try
            {
                if (Random.Shared.Next(5) == 0)
                    throw new IOException("Connection timeout");

                _savedOrders.Add(order);
            }
            catch (IOException)
            {
                Console.WriteLine("Save failed, continuing...");
            }
            finally
            {
                Console.WriteLine("Save :: Inside Finally");
            }
        }
    }

    // Order record
    public record Order(string Sku, int Quantity, decimal Total);

    
}
