namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var printer = new Printer();
            var queue = new PrintQueue();
            var logger = new Logger();

            var mediator = new PrintSystemMediator(printer, queue, logger);

            var dispatcher = new Dispatcher();
            dispatcher.SetMediator(mediator);

            var doc1 = new Document("Отчёт за квартал");
            var doc2 = new Document("Презентация");
            var doc3 = new Document("Договор аренды");

            doc1.SetMediator(mediator);
            doc2.SetMediator(mediator);
            doc3.SetMediator(mediator);

            Console.WriteLine("\nУспешная печать");
            doc1.AddToQueue();
            dispatcher.CommandProcessQueue();

            Console.WriteLine("\nОшибка принтера");
            doc2.AddToQueue();
            printer.SimulateFailure = true;
            dispatcher.CommandProcessQueue();

            Console.WriteLine("\nВосстановление");
            doc2.Reset();
            doc2.AddToQueue();
            printer.SimulateFailure = false;
            dispatcher.CommandProcessQueue();

            doc3.AddToQueue();
            dispatcher.CommandProcessQueue();
            Console.WriteLine("\nПопытка повторной печати");
            doc3.Print();
            Console.ReadKey();
        }
    }
}