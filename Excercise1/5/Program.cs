Console.Write("Enter Celsius: ");
double c = double.Parse(Console.ReadLine());

double f = (c * 9 / 5) + 32;
Console.WriteLine("Fahrenheit = " + f);

// ngược lại
double c2 = (f - 32) * 5 / 9;
Console.WriteLine("Back to Celsius = " + c2);