// See https://aka.ms/new-console-template for more information


using DesignPatterns2023.Adapter;
using DesignPatterns2023.Adapter.DataProcessor;
using DesignPatterns2023.Adapter.Network;
using DesignPatterns2023.ChainOfResponsibility;
using DesignPatterns2023.Facade;
using DesignPatterns2023.Factory.NetworkFactory;
using DesignPatterns2023.Factory.NetworkUtility;
using DesignPatterns2023.Proxy;
using DesignPatterns2023.Singleton;
using DesignPatterns2023.Strategy_Pattern;


#region Singleton
/*Singleton object1 = Singleton.Instance();
Singleton object2 = Singleton.Instance();

if (object1 == object2)
{
    Console.WriteLine("These objects are the same");
}
*/
#endregion

#region Factory Pattern
/*NetworkFactory factory = new NetworkFactory();
var dns = factory.GetNetworkInstance("dns");
var ping = factory.GetNetworkInstance("ping");
var arp = factory.GetNetworkInstance("arp");
dns.SendRequest("1.1.1", 1);
ping.SendRequest("1.1.1", 1);
arp.SendRequest("1.1.1", 1);*/
#endregion

#region Facade Pattern
/*NetworkFacade networkFacade = new NetworkFacade("1.1.1.1", "UDP");
networkFacade.BuildNetworkLayer();
networkFacade.SendPacketOverNetwork();*/
#endregion

#region Adapter Pattern
/*INetworkClient network = new NetworkClient();
network.SendRequest("1.1.1.1");

IDataProcessor dataProc = new DataProcessor();
dataProc.SendNetworkRequest("2.2.2.2", "23465gfhghg");

NetworkAdapter adapter = new NetworkAdapter(dataProc);
adapter.SendRequest("8.8.8.8");*/
#endregion

#region Proxy Pattern
/*ISuperSecretDatabase database = new SuperSecretDatabaseProxy("testdb", "Password");
database.DisplayDatabaseName();*/
#endregion

#region Chain of Responsibility Pattern
/*IChain obj1 = new SendSSH();
IChain obj2 = new SendPing();
IChain obj3 = new SendARP();

obj1.SetNext(obj2);
obj2.SetNext(obj3);

NetworkModel request = new NetworkModel("8.8.8.8", false);
obj1.SendRequest(request);*/
#endregion

#region Strategy Pattern
Context context = new Context(new DesignPatterns2023.Strategy_Pattern.ARP());
Context contextTwo = new Context(new DesignPatterns2023.Strategy_Pattern.Ping());
Context contextThree = new Context(new DesignPatterns2023.Strategy_Pattern.DNS());

context.ExecuteStrategy();
contextTwo.ExecuteStrategy();
contextThree.ExecuteStrategy();
#endregion