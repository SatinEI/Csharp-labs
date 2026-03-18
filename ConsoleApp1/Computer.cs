using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Computer : ICloneable
    {
        public string? CPU { get; set; }
        public int RAM { get; set; }
        public string? GPU { get; set; }
        
        private readonly List<string> AdditionalComponents = new List<string>();
        public void Add(string comp)
        {
           AdditionalComponents.Add(comp);
        }

        public List<string> GetComponents()
        {
            return AdditionalComponents.ToList();
        }
        public void Display()
        {
            string line = $"Процессор: {CPU}, Видеокарта: {GPU}, Оперативная память: {RAM} GB";
            foreach (string comp in AdditionalComponents)
            {
                line += $", {comp}";
            }
            Console.WriteLine(line);
        }

        public Computer ShallowCopy()
        {
            Computer clone = (Computer)this.MemberwiseClone();
            return clone;
        }

        public Computer DeepCopy()
        {
            Console.WriteLine("--- Выполняется глубокое копирование (Deep Copy) ---");

            Computer clone = new Computer
            {
                CPU = this.CPU,
                RAM = this.RAM,
                GPU = this.GPU,
            };

            foreach (var component in this.AdditionalComponents)
            {
                clone.Add(string.Copy(component));
            }

            return clone;
        }

    }
}
