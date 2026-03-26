using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class EventHandlerBase
    {
        virtual string FormatMessage(string type, object data) { }
        virtual void SendMessage(string message) { }
        virtual void LogResult() { }
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
        // Данный метод определит последовательность вызовов
        //Обратите внимание на сигнатуру
        protected void ProcessEvent(MetricEventArgs e)
        {
            var message = FormatMessage(e.EventType, e.Data); //форматируем по стратегии
            SendMessage(message); //отправляем уведомление
            LogResult(); //логируем результат (опционально)
        }
    }
}
