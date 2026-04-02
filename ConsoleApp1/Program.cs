namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== КОНФИГУРАТОР КОМПЬЮТЕРНЫХ СИСТЕМ ===\n");

            // Factory
            Console.WriteLine("1. ФАБРИЧНЫЙ МЕТОД");
            var officePC = new OfficeComputerFactory().CreateComputer();
            var gamingPC = new GamingComputerFactory().CreateComputer();
            var homePC = new HomeComputerFactory().CreateComputer();

            Console.Write("Офисный ПК: "); officePC.Display();
            Console.Write("Игровой ПК: "); gamingPC.Display();
            Console.Write("Домашний ПК: "); homePC.Display();

            // Builder
            Console.WriteLine("\n2. СТРОИТЕЛЬ");
            var customPC = new ComputerBuilder()
                .WithCPU("AMD Ryzen 7 7800X3D")
                .WithGPU("AMD Radeon RX 7900 XTX")
                .WithRAM(48)
                .WithComponent("SSD NVMe 1TB")
                .WithComponent("SSD SATA 2TB")
                .WithComponent("Wi-Fi модуль")
                .Build();
            Console.Write("Кастомный ПК: "); customPC.Display();

            // Singleton
            Console.WriteLine("\n3. SINGLETON РЕЕСТР");
            var registry = PrototypeRegistry.Instance;
            var registry2 = PrototypeRegistry.Instance;
            Console.WriteLine($"Один экземпляр: {ReferenceEquals(registry, registry2)}");

            // Prototype
            registry.AddPrototype("office", new OfficeComputerFactory().CreateComputer());
            registry.AddPrototype("gaming", new GamingComputerFactory().CreateComputer());
            registry.AddPrototype("home", new HomeComputerFactory().CreateComputer());
            registry.AddPrototype("extreme", new ComputerBuilder()
                .WithCPU("Intel Core i9-13900KS")
                .WithGPU("NVIDIA RTX 4090 Ti")
                .WithRAM(128)
                .WithComponent("Жидкий азот")
                .Build());

            registry.DisplayAllPrototypes();

            // ShallowCopy and DeepCopy
            Console.WriteLine("\n4. ПОВЕРХНОСТНОЕ vs ГЛУБОКОЕ КОПИРОВАНИЕ");

            var testPC = new ComputerBuilder()
                .WithCPU("Intel Core i5-13600K")
                .WithGPU("NVIDIA RTX 4060 Ti")
                .WithRAM(16)
                .WithComponent("SSD 500GB")
                .WithComponent("Стандартный кулер")
                .Build();

            Console.WriteLine("\nОРИГИНАЛ:");
            testPC.Display();

            // Shallow copy
            var shallow = testPC.ShallowCopy();
            Console.WriteLine("\n--- ПОВЕРХНОСТНОЕ КОПИРОВАНИЕ ---");
            Console.WriteLine("Добавляем компонент в ПОВЕРХНОСТНУЮ копию...");
            shallow.Add("Новый компонент (добавлен в shallow copy)");

            Console.WriteLine("\nПоверхностная копия:");
            shallow.Display();
            Console.WriteLine("Оригинал:");
            testPC.Display();
            Console.WriteLine("РЕЗУЛЬТАТ: Компонент появился и в оригинале! (список один на двоих)");

            // Deep copy
            var deep = testPC.DeepCopy();
            Console.WriteLine("\n--- ГЛУБОКОЕ КОПИРОВАНИЕ ---");
            Console.WriteLine("Добавляем компонент в ГЛУБОКУЮ копию...");
            deep.Add("Новый компонент (добавлен в deep copy)");

            Console.WriteLine("\nГлубокая копия:");
            deep.Display();
            Console.WriteLine("Оригинал:");
            testPC.Display();
            Console.WriteLine("РЕЗУЛЬТАТ: Оригинал не изменился! (списки независимы)");

            // prototype test
            Console.WriteLine("\n5. ЗАЩИТА ПРОТОТИПОВ В РЕЕСТРЕ");
            Console.WriteLine("Берем копию игрового ПК из реестра и изменяем её...");

            var gamingFromRegistry = registry.GetPrototype("gaming");
            if (gamingFromRegistry != null)
            {
                gamingFromRegistry.Add("Турбо-режим");
                gamingFromRegistry.RAM = 128;
                Console.WriteLine("\nИзмененная копия:");
                gamingFromRegistry.Display();

                Console.WriteLine("\nОригинал в реестре:");
                registry.GetDirectReference("gaming")?.Display();
                Console.WriteLine("РЕЗУЛЬТАТ: Оригинал в реестре не поврежден!");
            }

            Console.WriteLine("\nПрограмма завершена.");
        }
    }
}