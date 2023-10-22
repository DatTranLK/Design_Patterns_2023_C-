// See https://aka.ms/new-console-template for more information


using DesignPatterns2023.Adapter;
using DesignPatterns2023.Adapter.DataProcessor;
using DesignPatterns2023.Adapter.Network;
using DesignPatterns2023.Builder;
using DesignPatterns2023.Builder.Models;
using DesignPatterns2023.ChainOfResponsibility;
using DesignPatterns2023.Decorator.Base;
using DesignPatterns2023.Decorator.Decorator;
using DesignPatterns2023.Facade;
using DesignPatterns2023.Factory.NetworkFactory;
using DesignPatterns2023.Factory.NetworkUtility;
using DesignPatterns2023.Observer.Models;
using DesignPatterns2023.Observer.Notifiers;
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
/*Context context = new Context(new DesignPatterns2023.Strategy_Pattern.ARP());
Context contextTwo = new Context(new DesignPatterns2023.Strategy_Pattern.Ping());
Context contextThree = new Context(new DesignPatterns2023.Strategy_Pattern.DNS());

context.ExecuteStrategy();
contextTwo.ExecuteStrategy();
contextThree.ExecuteStrategy();*/
#endregion

#region Builder Pattern
/*//Poor solution to generate a car object
var car = new Car(4, new SeatBelt("DatTest"), "black", new Windscreen("DatTest"), new Engine("Foot"));
Console.WriteLine(car.ToString());
Console.WriteLine("------------------------------------");
//Intermediate solution to generate a car object when using builder pattern
var carByBuilder = new CarBuilder()
                        .AddWheels(4)
                        .AddSeatBelts(new SeatBelt("DatTest"))
                        .AddEngine(new Engine("DatTestEngine"))
                        .AddWindscreen(new Windscreen("DatTestWindScreen"))
                        .Paint("black")
                        .Build();
Console.WriteLine(carByBuilder.ToString());*/
#endregion

#region Observer Pattern
/*var videoData = new VideoData();
_ = new EmailNotifier(videoData);
_ = new PhoneNotifier(videoData);
var youtubeNotifier = new YoutubeNotifier(videoData);

videoData.SetTitle("Observer Design Pattern");

videoData.DetachObserver(youtubeNotifier);
Console.WriteLine("-----------------------------");
videoData.SetDescription("DatTest");

_ = new FacebookNotifier(videoData);
Console.WriteLine("-----------------------------");
videoData.SetFileName("Test File Name");*/

#endregion

#region Decorator Pattern
var firstMilkTea = new EggPudding(
                    new FruitPudding(
                        new BlackSugar(
                                new Bubble(
                                    new MilkTea()))));
Console.WriteLine("EggPuddingAndFruitPuddingBlackSugarBubbleMilkTea:\t" + firstMilkTea.Cost());

var secondMilkTea = new EggPudding(
                        new BlackSugar(
                            new WhiteBubble(
                                new MilkTea())));
Console.WriteLine("EggPuddingBlackSugarWhiteBubbleMilkTea:\t" + secondMilkTea.Cost());

#endregion