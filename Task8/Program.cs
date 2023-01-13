Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a * (0);
while (b <= a)
{
    Console.Write($"{b} ");
    b = b + 2;
}

// Я к сожалению так и не понял как сделать так, чтобы вывод начинался с единицы, а не с нуля.