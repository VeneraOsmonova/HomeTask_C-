/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет

12821 -> да

23432 -> да*/

System.Console.WriteLine("Введите пятизначное число: ");
int fiveDigNum = Convert.ToInt32(Console.ReadLine());

bool Palindrom(int num)
{
    int dig1 = fiveDigNum / 10000;
    int dig2 = fiveDigNum / 1000 % 10;
    int dig4 = fiveDigNum % 100 / 10;
    int dig5 = fiveDigNum % 10; 

    if (dig1 == dig5 && dig2 == dig4)
    return true;
    return false;
}
 
bool result = Palindrom(fiveDigNum);
if (result)
{
System.Console.WriteLine($"{fiveDigNum} -> Да");
}
else
{
System.Console.WriteLine($"{fiveDigNum} -> Нет");
}


    





