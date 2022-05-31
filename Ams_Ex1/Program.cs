
int idadeMin = 0;
int idadeMax = 0;
int MediaAluno = 0;

Console.WriteLine("Digite a idade Minima");
idadeMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a idade maxima");
idadeMax = Convert.ToInt32(Console.ReadLine());
MediaAluno = (idadeMin + idadeMax) /2;

Console.WriteLine($"A média do aluno é: {MediaAluno}");
