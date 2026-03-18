using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== КОНФИГУРАТОР КОМПЬЮТЕРНЫХ СИСТЕМ ===\n");
            Console.WriteLine("Демонстрация паттернов: Builder, Factory Method и Prototype\n");

            IComputerFactory officeFactory = new OfficeComputerFactory();
            Computer officePC = officeFactory.CreateComputer();
            Console.Write("Офисный ПК: ");
            officePC.Display();

            IComputerFactory gamingFactory = new GamingComputerFactory();
            Computer gamingPC = gamingFactory.CreateComputer();
            Console.Write("Игровой ПК: ");
            gamingPC.Display();

            IComputerFactory homeFactory = new HomeComputerFactory();
            Computer homePC = homeFactory.CreateComputer();
            Console.Write("Домашний ПК: ");
            homePC.Display();

            Console.WriteLine("\nЧАСТЬ 2: СТРОИТЕЛЬ (Builder)");
            Console.WriteLine("==============================");

            ComputerBuilder builder = new ComputerBuilder();
            Computer customPC = builder
                .WithCPU("AMD Ryzen 7 7800X3D")
                .WithGPU("AMD Radeon RX 7900 XTX")
                .WithRAM(48)
                .WithComponent("SSD NVMe 1TB")
                .WithComponent("SSD SATA 2TB")
                .WithComponent("Wi-Fi модуль")
                .Build();

            Console.Write("Пользовательский ПК: ");
            customPC.Display();

            Console.WriteLine("\nЧАСТЬ 3: ПРОТОТИП (Prototype)");
            Console.WriteLine("================================");

            Console.WriteLine("\n--- Исходный объект (игровой ПК) ---");
            gamingPC.Display();

            Console.WriteLine("\n--- ТЕСТ 1: Поверхностное копирование (Shallow Copy) ---");
            Computer shallowClone = gamingPC.ShallowCopy();

            Console.WriteLine("\n>> Изменяем данные в ПОВЕРХНОСТНОМ клоне:");
            shallowClone.CPU = "Измененный CPU в клоне";
            shallowClone.Add("Новый компонент ТОЛЬКО В КЛОНЕ");

            Console.WriteLine("\nПоверхностный клон после изменений:");
            shallowClone.Display();

            Console.WriteLine("\nОригинал после изменений в поверхностном клоне:");
            gamingPC.Display();
            Console.WriteLine("-> ВНИМАНИЕ: Имя владельца изменилось и в оригинале!");
            Console.WriteLine("   (потому что Owner - ссылочный тип, и скопировалась только ссылка)");

            Console.WriteLine("\n--- ТЕСТ 2: Глубокое копирование (Deep Copy) ---");
            Computer deepClone = gamingPC.DeepCopy();

            Console.WriteLine("\n>> Изменяем данные в ГЛУБОКОМ клоне:");
            deepClone.CPU = "Другой CPU в глубоком клоне";
            deepClone.Add("Компонент ТОЛЬКО В ГЛУБОКОМ КЛОНЕ");

            Console.WriteLine("\nГлубокий клон после изменений:");
            deepClone.Display();

            Console.WriteLine("\nОригинал после изменений в глубоком клоне:");
            gamingPC.Display();
        }
    }
}