/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите количество строк в двумерном массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двумерном массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] FillMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // 2
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void PrintArray(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i],6} ");
    }
}

double[] AverageInColumns(int[,] matrix)
{
    double[] arrAvarage = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++) // 2
    {
        for (int i = 0; i < matrix.GetLength(0); i++) //
        {
            arrAvarage[j] += matrix[i, j]; // 2 - 3
        }
        arrAvarage[j] = arrAvarage[j] / matrix.GetLength(0);

    }
    return arrAvarage;
}

Console.WriteLine();
int[,] fillMatrixRndInt = FillMatrixRndInt(row, column, -10, 100);
PrintMatrix(fillMatrixRndInt);

double[] arrResult = AverageInColumns(fillMatrixRndInt);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца");
PrintArray(arrResult);
