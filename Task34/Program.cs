/*Задача 34: 
1. Задайте массив заполненный 
2. случайными положительными трёхзначными числами. 
Напишите программу, которая 
3. покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int AmountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] arr = CreateArrayRndInt(num);
PrintArray(arr);
int amountEvenNumbers = AmountEvenNumbers(arr);
Console.WriteLine(amountEvenNumbers);
