using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Factory.NetworkUtility
{
    public class ARP : INetwork
    {
        public void SendRequest(string ip, int timeSent)
        {
            Console.WriteLine("ARP request sent to " + ip + " " + timeSent + " times");
        }
    }
}
