double graus_Celsius = 0;
double fahrenheit = 0;

Console.WriteLine("Quantos é a temperatura em graus celsius?");
graus_Celsius = Convert.ToUInt32(Console.ReadLine());

fahrenheit = (9*graus_Celsius + 160)/5;

Console.WriteLine($"A conversão de graus Celsius para fahrenheit é {fahrenheit}");