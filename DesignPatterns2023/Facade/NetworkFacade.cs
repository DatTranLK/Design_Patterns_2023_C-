using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Facade
{
    public class NetworkFacade
    {
        private Packet packet;
        private Socket socket;
        private Transmission transmission;
        public NetworkFacade(string ip, string protocol)
        {
            this.packet = new Packet(ip);
            this.socket = new Socket(protocol);
            this.transmission = new Transmission(protocol);
        }
        public void BuildNetworkLayer()
        {
            packet.PacketBuilt();
            socket.BuildSocket();
            
        }
        public void SendPacketOverNetwork()
        {
            BuildNetworkLayer();
            transmission.SendTransmission();
        }
    }
}
