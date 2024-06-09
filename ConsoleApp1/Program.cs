// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
var network = new Network(8);
network.Connect(1, 2);
network.Connect(1, 6);
network.Connect(2, 6);
network.Connect(2, 4);
network.Connect(5, 8);
var isConnect = network.Query(8, 6);
Console.WriteLine(isConnect);