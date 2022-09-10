//Найти сумму элементов от M до N, N и M заданы

int SumNumber(int m, int n)
{
    if (m == n) return m;
    return m + SumNumber(m + 1, n);
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма элементов от M до N равна {SumNumber(m, n)}");