/*Задача 2: Напишите программу, которая 
1. на вход принимает два числа
2. выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 ->  max = 7      a = 2; b = 10 -> max = 10         a = -9; b = -3 -> max = -3*/

System.Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());


if (a > b) 
{
    System.Console.WriteLine($"Максимальное число = {a}");
}
else 
{ 
    System.Console.WriteLine($"Максимальное число = {b}");
}
