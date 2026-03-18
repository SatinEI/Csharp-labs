namespace ConsoleApp1
{
    public class Computer
    {
        public string? CPU { get; set; }
        public int RAM { get; set; }
        public string? GPU { get; set; }

        private readonly List<string> AdditionalComponents = new List<string>();

        public void Add(string comp) => AdditionalComponents.Add(comp);
        public List<string> GetComponents() => AdditionalComponents.ToList();

        public void Display()
        {
            string line = $"Процессор: {CPU}, Видеокарта: {GPU}, RAM: {RAM} GB";

            if (AdditionalComponents.Any())
            {
                line += ", Компоненты:";
                foreach (string comp in AdditionalComponents)
                    line += $" {comp};";
            }
            Console.WriteLine(line);
        }

        public Computer ShallowCopy()
        {
            return (Computer)this.MemberwiseClone();
        }

        public Computer DeepCopy()
        {
            Computer clone = new Computer
            {
                CPU = this.CPU,
                RAM = this.RAM,
                GPU = this.GPU
            };

            foreach (var component in this.AdditionalComponents)
                clone.Add(component);

            return clone;
        }
    }
}