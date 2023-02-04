// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 -> max = 7 a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine("a is max = " + a);
    System.Console.WriteLine("b is min = " + b);
}
else
{
    System.Console.WriteLine("b is max = " + b);
    System.Console.WriteLine("a is min = " + a);
}
// Если нужно просто max выводить то нужно просто из условия убрать строки  
//System.Console.WriteLine("B min " + b); и System.Console.WriteLine("A min " + a);
