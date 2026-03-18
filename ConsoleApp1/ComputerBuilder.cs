using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ComputerBuilder
    {
        private Computer _computer = new Computer();
        public ComputerBuilder WithCPU(string cpu) {
            _computer.CPU = cpu;
                return this; }
        public ComputerBuilder WithGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }
        public ComputerBuilder WithRAM(int ram)
        {
            _computer.RAM = ram;
            return this;
        }
        public ComputerBuilder WithComponent(string component)
        {
            _computer.Add(component);
            return this;
        }
        public Computer Build()
        {
            if (string.IsNullOrEmpty(_computer.CPU))
                throw new InvalidOperationException("CPU не может быть пустым");

            if (string.IsNullOrEmpty(_computer.GPU))
                throw new InvalidOperationException("GPU не может быть пустым");

            if (_computer.RAM <= 0)
                throw new InvalidOperationException("RAM должна быть больше 0");

            return _computer;
        }
    }
}
