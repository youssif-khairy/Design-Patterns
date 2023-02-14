//Creational DP


using Singleton_Pattern;

var x = President.CreatePresident();
var y = President.CreatePresident();

Console.WriteLine(x == y ? "Same Instances" : "Diffrent Instances");
