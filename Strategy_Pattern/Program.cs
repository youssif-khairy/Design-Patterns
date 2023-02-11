//Behavioral DP
//As is it Define how object behave based on his type that is known in run time
using Strategy_Pattern.Childs;
using Strategy_Pattern.Interfaces;

IReader reader = new ReadToXML();
Console.WriteLine(reader.Read());
