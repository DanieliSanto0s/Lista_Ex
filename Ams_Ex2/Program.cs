using System.Data;
double euro = 5.13;
double real = 0;
double quant = 0;

Console.WriteLine("Insira o valor do euro: ");
quant = Convert.ToInt32(Console.ReadLine());


real = (quant * euro);
Console.WriteLine($"O valor convertido em real é: {real}");

