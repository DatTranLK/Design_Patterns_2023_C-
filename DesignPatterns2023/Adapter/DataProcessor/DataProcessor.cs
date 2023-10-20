using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Adapter.DataProcessor
{
    public class DataProcessor : IDataProcessor
    {
        public bool DataProcess()
        {
            Console.WriteLine("Processed data");
            return true;
        }
        public void SendNetworkRequest(string ip, string apiKey)
        {
            Console.WriteLine("Send network request with IP address that requires API KEY: " + ip);
        }
    }
}
