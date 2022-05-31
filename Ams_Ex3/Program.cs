double venda = 0;
double comissao = 5;
double resultado = 0;

Console.WriteLine("Qual valor você arrecadou?");
venda = Convert.ToInt32(Console.ReadLine());
resultado = (venda * comissao /100);

Console.WriteLine($"o valor recebido vai ser {resultado}");

