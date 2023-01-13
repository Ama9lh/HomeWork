Console.Clear();
Console.Write("Введите свое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) Console.Write("Да");
else
    {
        Console.Write("Нет");
    }