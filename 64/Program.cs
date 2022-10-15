// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
Console.Clear();
string NatNums(int n)
{
    if (n == 1)
        return "1";
    return $"{n}, " + NatNums(n - 1);
}
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
string s = NatNums(n);
Console.WriteLine(s);