/*Задача 8: Напишите программу, которая 
1. на вход принимает число (N)
2. на выходе показывает все чётные числа от 1 до N. 5 -> 2, 4;    8 -> 2, 4, 6, 8;*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;
while (count <= number)
{
    System.Console.Write($"{count} ");
    count += 2;
}