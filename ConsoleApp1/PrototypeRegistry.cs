namespace ConsoleApp1
{
    public sealed class PrototypeRegistry
    {
        private static volatile PrototypeRegistry? _instance;
        private static readonly object _lock = new object();
        private readonly Dictionary<string, Computer> _prototypes;

        private PrototypeRegistry()
        {
            _prototypes = new Dictionary<string, Computer>();
        }

        public static PrototypeRegistry Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new PrototypeRegistry();
                    }
                }
                return _instance;
            }
        }

        public void AddPrototype(string key, Computer prototype)
        {
            key = key.ToLower();
            _prototypes[key] = prototype;
        }

        public Computer? GetPrototype(string key)
        {
            if (_prototypes.TryGetValue(key.ToLower(), out Computer? prototype))
                return prototype.DeepCopy();
            return null;
        }

        public Computer? GetDirectReference(string key)
        {
            _prototypes.TryGetValue(key.ToLower(), out Computer? prototype);
            return prototype;
        }

        public void DisplayAllPrototypes()
        {
            Console.WriteLine("\n--- Реестр прототипов ---");
            foreach (var kvp in _prototypes)
            {
                Console.Write($"[{kvp.Key}]: ");
                kvp.Value.Display();
            }
        }
    }
}