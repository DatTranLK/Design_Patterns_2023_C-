using DesignPatterns2023.Adapter.DataProcessor;
using DesignPatterns2023.Adapter.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Adapter
{
    public class NetworkAdapter : INetworkClient
    {
        private readonly IDataProcessor _dataProcessor;

        public NetworkAdapter(IDataProcessor dataProcessor)
        {
            _dataProcessor = dataProcessor;
        }
        public void SendRequest(string ipAddress)
        {
            var apiKey = "34sdfg54sdgfg34543";
            _dataProcessor.SendNetworkRequest(ipAddress, apiKey);
        }
    }
}
