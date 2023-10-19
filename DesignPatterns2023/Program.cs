// See https://aka.ms/new-console-template for more information


using DesignPatterns2023.Factory.NetworkFactory;
using DesignPatterns2023.Factory.NetworkUtility;
using DesignPatterns2023.Singleton;
using System.Net.NetworkInformation;

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
NetworkFactory factory = new NetworkFactory();
var dns = factory.GetNetworkInstance("dns");
var ping = factory.GetNetworkInstance("ping");
var arp = factory.GetNetworkInstance("arp");
dns.SendRequest("1.1.1", 1);
ping.SendRequest("1.1.1", 1);
arp.SendRequest("1.1.1", 1);
#endregion