int n1 = 0;
int n2 = 0;
int n3 = 0;
int n4 = 0;
int media = 0;

Console.WriteLine("Digite a primeira Nota");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a segunda Nota");
n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a terceira Nota");
n3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quarta Nota");
n4 = Convert.ToInt32(Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4;

if (media > 7)
{
    Console.WriteLine($"O aluno está aprovado e a sua nota final é {media}");
}

else
{
    Console.WriteLine($"O aluno está reprovado e a sua nota final é {media}");
}


