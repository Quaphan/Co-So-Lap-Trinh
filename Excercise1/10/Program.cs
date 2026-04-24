Console.Write("Enter days: ");
int days = int.Parse(Console.ReadLine());

int years = days / 365;
int weeks = (days % 365) / 7;
int remainingDays = (days % 365) % 7;

Console.WriteLine($"{years} years, {weeks} weeks, {remainingDays} days");