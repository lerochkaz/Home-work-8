// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] RequestForNumbers()
{
    Console.Write("Введите число строк: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите число столбцов: ");
    int n = int.Parse(Console.ReadLine()!);
    int[,] array = new int[m, n];
    return array;
}

int[,] FillArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Random generator = new Random();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortMatrixRow(int[,] matrix)
{
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[rowIndex, i] < matrix[rowIndex, j])
                {
                    int buff = matrix[rowIndex, i];
                    matrix[rowIndex, i] = matrix[rowIndex, j];
                    matrix[rowIndex, j] = buff;
                }
            }
        }
    }
}

int[,] newArray = RequestForNumbers();
int[,] newMatrix = FillArray(newArray);
PrintArray(newMatrix);
SortMatrixRow(newMatrix);
Console.WriteLine();
PrintArray(newMatrix);

