using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.ChainOfResponsibility
{
    public interface IChain
    {
        void SendRequest(NetworkModel request);
        void SetNext(IChain nextChain);
    }
}
