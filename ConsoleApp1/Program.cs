// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Teste de lógica Benner");
var network = new Network(8);
network.Connect(1, 2);
network.Connect(2, 3);
network.Connect(3, 4);
network.Connect(5, 6);

Console.WriteLine("Conexões:");
Console.WriteLine("1 - 2:");
Console.WriteLine("2 - 3:");
Console.WriteLine("3 - 4:");
Console.WriteLine("5 - 6:");
Console.WriteLine("");
Console.WriteLine($"1-2: Esperado True > Resultado {network.Query(1, 2)}");
Console.WriteLine($"2-1: Esperado True > Resultado {network.Query(2, 1)}");
Console.WriteLine($"1-3: Esperado True > Resultado {network.Query(1, 3)}");
Console.WriteLine($"3-1: Esperado True > Resultado {network.Query(3, 1)}");
Console.WriteLine($"1-4: Esperado True > Resultado {network.Query(1, 4)}");
Console.WriteLine($"4-1: Esperado True > Resultado {network.Query(4, 1)}");
Console.WriteLine($"1-5: Esperado False > Resultado {network.Query(1, 5)}");
Console.WriteLine($"5-1: Esperado False > Resultado {network.Query(5, 1)}");
Console.WriteLine($"1-6: Esperado False > Resultado {network.Query(1, 6)}");
Console.WriteLine($"6-1: Esperado False > Resultado {network.Query(6, 1)}");