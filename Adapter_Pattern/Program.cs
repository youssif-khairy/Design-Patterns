// See https://aka.ms/new-console-template for more information

using Adapter;
IAdaptee adaptee = new Adaptee();
ITarget adapter = new Adapter.Adapter(adaptee);


Console.WriteLine(adapter.GetRequestString());
