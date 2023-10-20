using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.ChainOfResponsibility
{
    public class NetworkModel
    {
        public string IP { get; set; }
        public bool Success { get; set; }
        public NetworkModel(string ip, bool success)
        {
            this.IP = ip;
            this.Success = success;
        }
    }
}
