// Задача 56.Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] SumMatrixRow(int[,] matrix)
{
    int[] resultArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {

            sumRow = sumRow + matrix[i, j];
        }
        resultArray[i] = sumRow;
    }
    return resultArray;
}

void PrintResult(int[] resultArray)
{
    int result = 0;
    for (int i = 0; i < resultArray.Length; i++)
    {
        if (resultArray[i] < result)
        {
            result = resultArray[i];
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов №{result + 1}");
}

int[,] newArray = RequestForNumbers();
int[,] newMatrix = FillArray(newArray);
PrintArray(newMatrix);
int[] resultMatrix = SumMatrixRow(newMatrix);
PrintResult(resultMatrix);
