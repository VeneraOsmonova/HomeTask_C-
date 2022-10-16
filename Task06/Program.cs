/*Задача 6: Напишите программу, которая 
1. на вход принимает число
2. выдаёт, является ли число чётным (делится ли оно на два без остатка). 4 -> да;  -3 -> нет;  7 -> нет*/

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
