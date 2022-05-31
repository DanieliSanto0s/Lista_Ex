int A = 0;
int B = 0;
int Total = 0;


Console.WriteLine("Digite um número");
A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número");
B = Convert.ToInt32(Console.ReadLine());

Total = A - B;

if (Total < 0)
{
    Console.WriteLine($"O resultado é um total negativo {Total}");
}

else
{
    Console.WriteLine($"O resultado é um total positivo {Total}");
}


