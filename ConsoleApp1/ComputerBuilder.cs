namespace ConsoleApp1
{
    public class ComputerBuilder
    {
        private Computer _computer = new Computer();

        public ComputerBuilder WithCPU(string cpu) { _computer.CPU = cpu; return this; }
        public ComputerBuilder WithGPU(string gpu) { _computer.GPU = gpu; return this; }
        public ComputerBuilder WithRAM(int ram) { _computer.RAM = ram; return this; }
        public ComputerBuilder WithComponent(string component) { _computer.Add(component); return this; }

        public Computer Build()
        {
            if (string.IsNullOrEmpty(_computer.CPU) || string.IsNullOrEmpty(_computer.GPU) || _computer.RAM <= 0)
                throw new InvalidOperationException("Не заполнены обязательные поля");
            return _computer;
        }

        public void Reset() {
            _computer = new Computer(); 
        }
    }
}