using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .Build();
        }
    }
}
