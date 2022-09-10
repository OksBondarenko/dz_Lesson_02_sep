//Показать натуральные числа от M до N, N и M заданы

void Number(int m, int n)
{
    if (n >= m)
    {
        Console.Write(m + " "); 
        Number(m + 1, n);
    }
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Number(m, n);