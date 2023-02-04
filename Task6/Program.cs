// Напишите программу, которая на вход принимает число и выдает, является ли число четным 
// (делится ли оно на два без остатка).
// 4 -> да -3 -> нет 7 -> нет

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0) 
{
    Console.WriteLine("Четное");
}
else Console.WriteLine("Нечетное");
