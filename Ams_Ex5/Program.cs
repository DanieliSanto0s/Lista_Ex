double graus_Fahrenheit = 0;
double celsius = 0;

Console.WriteLine("Quantos graus Fahrenheit?");
graus_Fahrenheit = Convert.ToInt32(Console.ReadLine());

celsius = (graus_Fahrenheit -32) * 5 / 9;

Console.WriteLine($"A conversão de graus Fahrenheit para celsius é {celsius}");