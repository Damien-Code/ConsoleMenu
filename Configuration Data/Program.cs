namespace Configuration_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigurationData config1 = new ConfigurationData("extra exercise 5", 12, 150);
            Console.WriteLine($"{config1.ApplicationName} {config1.Version} {config1.MaxUsers}");
        }
    }

    class ConfigurationData
    {
        private string _applicationName;
        private int _version;
        private int _maxUsers;

        public string ApplicationName { get => _applicationName; }
        public int Version { get => _version; }
        public int MaxUsers { get => _maxUsers; }

        public ConfigurationData()
        {
            _applicationName = "Extra Exercise";
            _version = 1;
            _maxUsers = 100;
        }

        public ConfigurationData(string applicationName, int version, int maxUsers)
        {
            _applicationName = applicationName;
            _version = version;
            _maxUsers = maxUsers;
        }
    }

}
