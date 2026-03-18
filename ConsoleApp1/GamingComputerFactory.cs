namespace ConsoleApp1
{
    internal class GamingComputerFactory : IComputerFactory
    {
        public Computer CreateComputer()
        {
            return new ComputerBuilder()
                .WithCPU("Intel Core i9-13900K")
                .WithGPU("NVIDIA RTX 4090 24GB")
                .WithRAM(64)
                .WithComponent("SSD NVMe 2TB")
                .WithComponent("Водяное охлаждение")
                .WithComponent("Игровая клавиатура")
                .WithComponent("Игровая мышь")
                .WithComponent("Игровая гарнитура")
                .Build();
        }
    }
}