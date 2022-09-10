/*Написать программу показывающие первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем*/


void Fibonacci (int a, int b, int n)
{
    Console.Write(a + " ");
    if (n > 1) Fibonacci(b, a + b, n - 1);
}

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Fibonacci(a, b, n);