using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns2023.ChainOfResponsibility
{
    public class SendPing : IChain
    {
        private IChain next;
        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("Send Ping failed. Sending ARP");
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send Ping Success");
            }
        }

        public void SetNext(IChain nextChain)
        {
            this.next = nextChain;
        }
    }
}
