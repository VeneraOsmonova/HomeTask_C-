/*Задача 13: Напишите программу, которая 
2. выводит третью цифру 
1. заданного числа или сообщает, что 
3. третьей цифры нет. 645 -> 5;  78 -> третьей цифры нет;  32679 -> 6*/


System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number < 100)
// {
//     System.Console.WriteLine($"Третьей цифры нет");
// }
// else
// {
//     while (number > 1000)
//     {
//         number = number / 10;
//     }
//     System.Console.WriteLine($"Третья цифра: {number % 10}");
// }



int GetThirdDigit(int number)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    int thirdDigit = number % 10;
    return thirdDigit;
}
if (number < 100)
{
   System.Console.WriteLine($"Третьей цифры нет"); 
}
else 
{ 
   int thirdDigit = GetThirdDigit(number);           
   Console.WriteLine($"Третья цифра: {thirdDigit}"); 
}









