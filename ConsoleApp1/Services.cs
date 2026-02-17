namespace ConsoleApp1
{
    using System;

    public interface IMessageSender
    {
        void SendMessage(string recipient, string message);
    }
    public class EmailService : IMessageSender
    {
        public void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }

    public class SmsService : IMessageSender
    {
        public void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }

    public class OrderService
    {
        private readonly IMessageSender _emailSender;
        private readonly IMessageSender _smsSender;
        public OrderService(IMessageSender emailSender, IMessageSender smsSender)
        {
            _emailSender = emailSender;
            _smsSender = smsSender;
        }

        public void PlaceOrder(Order order)
        {
            _emailSender.SendMessage(order.CustomerEmail, "Your order has been placed");
            _smsSender.SendMessage(order.CustomerPhone, "Your order has been placed");
        }
    }

    public class NotificationServices
    {
        private readonly IMessageSender _messageSender;
        public NotificationServices(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }
        public void SendPromotion(string email, string promotion)
        {
            _messageSender.SendMessage(email, $"Special Promotion: {promotion}");
        }
    }
}
