/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого элемента в массиве нет*/

Console.WriteLine("Введите количество строк в двумерном массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двумерном массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] FillMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

void SearchElementInMatrix(int[,] matrix, int rows, int columns)
{
    if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент массива с индексом [{rows},{columns}] = {matrix[rows, columns]}");
    }
    else
    {
        Console.WriteLine("Элемента с таким индексом в массиве нет");
    }
}

int[,] fillMatrixRndInt = FillMatrixRndInt(row, column, 1, 20);
PrintMatrix(fillMatrixRndInt);

Console.WriteLine("Введите порядковый номер строки: ");
int rowSearch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите порядковый номер столбца: ");
int columnSearch = Convert.ToInt32(Console.ReadLine());

SearchElementInMatrix(fillMatrixRndInt3, rowSearch, columnSearch);