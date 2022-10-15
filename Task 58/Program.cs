// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] InputDimensionOfMatrix()
{
    Console.WriteLine("Введите размер квадратной матрицы: ");
    // int size = int.Parse(Console.ReadLine()!);
    int size = 2;
    int[,] matrix = new int[size, size];
    return matrix;
}

void FillMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Random generator = new Random();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = generator.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FindingTheSum(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    if (firstMatrix.GetLength(0) == secondMatrix.GetLength(0) && firstMatrix.GetLength(1) == secondMatrix.GetLength(1))
    {
        // int[,] resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

        resultMatrix[0, 0] = (firstMatrix[0, 0] * secondMatrix[0, 0]) + (firstMatrix[0, 1] * secondMatrix[1, 0]);
        resultMatrix[1, 0] = (firstMatrix[1, 0] * secondMatrix[0, 0]) + (firstMatrix[1, 1] * secondMatrix[1, 0]);
        resultMatrix[0, 1] = (firstMatrix[0, 0] * secondMatrix[0, 1]) + (firstMatrix[0, 1] * secondMatrix[1, 1]);
        resultMatrix[1, 1] = (firstMatrix[1, 0] * secondMatrix[0, 1]) + (firstMatrix[1, 1] * secondMatrix[1, 1]);
        return resultMatrix;
    }
    else
    {
        Console.WriteLine("Необходимо ввести другой размер матрицы");
    }
    return resultMatrix;

}

int[,] newMatrixFirst = InputDimensionOfMatrix();
FillMatrix(newMatrixFirst);
PrintMatrix(newMatrixFirst);
int[,] newMatrixSecond = InputDimensionOfMatrix();
FillMatrix(newMatrixSecond);
PrintMatrix(newMatrixSecond);
int[,] resultMatrix = FindingTheSum(newMatrixFirst, newMatrixSecond);
Console.WriteLine("Произведение двух матриц: ");
PrintMatrix(resultMatrix);


