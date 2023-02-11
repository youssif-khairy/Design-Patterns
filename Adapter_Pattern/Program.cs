//structural DP
using Adapter;
IAdaptee adaptee = new Adaptee();
ITarget adapter = new Adapter.Adapter(adaptee);


Console.WriteLine(adapter.GetRequestString());
