// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = n; i >= 1; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Четные числа до введенного числа: " + i);
    }
}
