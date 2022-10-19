/*Задача 15: Напишите программу, которая 
1. принимает на вход цифру, обозначающую день недели, и 
2. проверяет, является ли этот день выходным.   1 -> нет;   7 -> да;   6 -> да*/

System.Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());


if (day > 0 && day < 8)
{

    if (day == 1)
    {
        System.Console.WriteLine("Нет");
    }
    else if (day == 2)
    {
        System.Console.WriteLine("Нет");
    }
    else if (day == 3)
    {
        System.Console.WriteLine("Нет");
    }
    else if (day == 4)
    {
        System.Console.WriteLine("Нет");
    }
    else if (day == 5)
    {
        System.Console.WriteLine("Нет");
    }
    else if (day == 6)
    {
        System.Console.WriteLine("Да");
    }
    else if (day == 7)
    {
        System.Console.WriteLine("Да");
    }
}
else
{
    System.Console.WriteLine("Заданное число не соответствует дню недели");
}



