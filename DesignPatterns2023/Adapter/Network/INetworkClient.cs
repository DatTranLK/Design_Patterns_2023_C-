using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Adapter.Network
{
    public interface INetworkClient
    {
        void SendRequest(string ipAddress);
    }
}
