int A = 0;
int B = 0;
int Total = 0;

Console.WriteLine("Digite um número");
A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número");
B = Convert.ToInt32(Console.ReadLine());

Total = A % B;

if (B == 0)
{
    Console.WriteLine($"NÃO É POSSIVEL FAZER DIVISÃO COM 0");
}

else
{
    Console.WriteLine($"A sobra da divisão é {Total}");
}


