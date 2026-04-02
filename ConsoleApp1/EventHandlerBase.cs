using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class EventHandlerBase
    {
        protected IFormatStrategy _formatStrategy; //текущая стратегия
        protected EventHandlerBase(IFormatStrategy strategy)
        {
            _formatStrategy = strategy;
        }
        //Метод установки стратегии
        public void SetStrategy(IFormatStrategy strategy)
        {
            _formatStrategy = strategy;
        }
        public virtual string FormatMessage(string type, object data)
        {
            string format_message = $"{type}: {data.ToString()}";

            return _formatStrategy.Format(format_message, DateTime.Now);
        }
        public virtual void SendMessage(string message)
        {
            Console.WriteLine($"{message}");
        }
        // Данный метод определит последовательность вызовов
        //Обратите внимание на сигнатуру
        protected void ProcessEvent(MetricEventArgs e)
        {
            var message = FormatMessage(e.EventType, e.Data); //форматируем по стратегии
            SendMessage(message); //отправляем уведомление
        }
    }
}
