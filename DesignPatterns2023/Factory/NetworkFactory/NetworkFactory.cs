using DesignPatterns2023.Factory.NetworkUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Factory.NetworkFactory
{
    public class NetworkFactory
    {
        public INetwork GetNetworkInstance(string type)
        {
            INetwork network = null;
            switch (type.ToLower())
            {
                case "ping":
                    network = new Ping();
                    break;
                case "arp":
                    network = new ARP();
                    break;
                case "dns":
                    network = new DNS();
                    break;
                default:
                    Console.WriteLine("Type not found");
                    break;
            }
            return network;
        }
    }
}
