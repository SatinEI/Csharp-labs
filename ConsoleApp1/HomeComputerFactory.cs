namespace ConsoleApp1
{
    internal class HomeComputerFactory : IComputerFactory
    {
        public Computer CreateComputer()
        {
            return new ComputerBuilder()
                .WithCPU("Intel Core i5-13400")
                .WithGPU("NVIDIA RTX 3060 12GB")
                .WithRAM(32)
                .WithComponent("SSD 1TB")
                .WithComponent("HDD 2TB")
                .WithComponent("Blu-ray привод")
                .WithComponent("Кардридер")
                .Build();
        }
    }
}