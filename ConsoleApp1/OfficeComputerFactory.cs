namespace ConsoleApp1
{
    internal class OfficeComputerFactory : IComputerFactory
    {
        public Computer CreateComputer()
        {
            return new ComputerBuilder()
                .WithCPU("Intel Core i3-12100")
                .WithGPU("Встроенная графика Intel UHD")
                .WithRAM(8)
                .WithComponent("SSD 256GB")
                .WithComponent("Клавиатура")
                .WithComponent("Мышь")
                .Build();
        }
    }
}