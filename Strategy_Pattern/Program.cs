// See https://aka.ms/new-console-template for more information

using Strategy_Pattern.Childs;
using Strategy_Pattern.Interfaces;

IReader reader = new ReadToXML();
Console.WriteLine(reader.Read());


/*
 This Pattern is mainly seen when multiple swith case is used to be replace with this pattern
 */
