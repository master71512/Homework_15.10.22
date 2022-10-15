// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
int SumNums(int n, int m)
{
    if (n < m)
        return n + SumNums(n + 1, m);
    else
        return n;
}
Console.WriteLine("Введите число 1");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
    (n, m) = (m, n);
Console.WriteLine($"сумма чисел от {n} до {m} равна {SumNums(n, m)}");
