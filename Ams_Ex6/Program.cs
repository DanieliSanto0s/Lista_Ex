
double altura = 0;
double peso = 0;

Console.WriteLine("Informe sua altura com virgula");
altura = Convert.ToDouble(Console.ReadLine());

peso = ((72.7 * altura) - 58);


Console.WriteLine($"Seu peso ideal de acordo com sua altura é {peso}");

