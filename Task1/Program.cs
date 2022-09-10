//Показать натуральные числа от N до 1, N задано

void Number(int num)
{
    if (num >= 1) 
    {
        Console.Write(num + " ");
        Number(num - 1);
    }
}

Console.Write("Введите число: ");
Number(Convert.ToInt32(Console.ReadLine()));

