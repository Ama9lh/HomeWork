Console.Clear();
Console.WriteLine("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (n > m) max = n;
if (n < m) max = m;

Console.Write($"Ваше число: {max}");
