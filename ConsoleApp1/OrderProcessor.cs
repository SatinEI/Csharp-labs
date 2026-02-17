namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class OrderProcessor
    {
        private List<Order> orders = new List<Order>();
        public void AddOrder(Order order)
        {
            orders.Add(order);
            Console.WriteLine($"Order {order.Id} added");
        }
        public Order GetOrder(int orderId)
        {
            return orders.FirstOrDefault(o => o.Id == orderId);
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }
    }

    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentMethod, decimal amount)
        {
            // Логика обработки платежа
            Console.WriteLine($"Processing {paymentMethod} payment of {amount:C}");
        }
    }

    public class InventoryManager
    {
        public void UpdateInventory(List<string> items)
        {
            Console.WriteLine($"Updating inventory for {items.Count} items");
        }
    }

    public class NotificationService
    {
        public void SendEmail(string to, string message)
        {
            Console.WriteLine($"Sending email to {to}: {message}");
        }
    }

    public class Logger
    {
        public void LogToDatabase(string message)
        {
            Console.WriteLine($"Logging to database: {message}");
        }
    }

    public class DocumentGenerator
    {
        public void GenerateReceipt(Order order)
        {
            Console.WriteLine($"Generating receipt for order {order.Id}");
        }
    }

    public class ReportGenerator
    {
        public void GenerateMonthlyReport(List<Order> orders)
        {
            decimal totalRevenue = orders.Sum(o => o.TotalAmount);
            int totalOrders = orders.Count;
            Console.WriteLine($"Monthly Report: {totalOrders} orders, Revenue: {totalRevenue:C}");
        }
    }

    public class ExcelExporter
    {
        public void ExportToExcel(List<Order> orders, string filePath)
        {
            Console.WriteLine($"Exporting {orders.Count} orders to {filePath}");
        }
    }
}