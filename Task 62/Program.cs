// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void circle(int k, int M, int N, ref int[,] arr, ref int nums, ref int p)
{
    // levo pravo
    for (int i = 0 + k; i < M - k; i++)
    {
        if (arr[N - N + k, i] == 0)
            arr[N - N + k, i] = nums;
        nums++;
    }
    // verh niz
    nums--;
    for (int i = 0 + k; i < N - k; i++)
    {
        if (arr[i, M - 1 - k] == 0)
            arr[i, M - 1 - k] = nums;
        nums++;
    }
    // pravo levo
    nums--;
    for (int i = M - p; i >= 0 + k; i--)
    {
        if (arr[N - 1 - k, i] == 0)
            arr[N - 1 - k, i] = nums;
        nums++;
    }
    // niz verh
    nums--;
    for (int i = N - p; i > 0 + k; i--)
    {
        if (arr[i, 0 + k] == 0)
            arr[i, 0 + k] = nums;
        nums++;
    }
    p++;
}



int[,] generateFilledSquareMatrix(int M, int N)
{
    int[,] matrix = new int[M, N];
    int nums = 1;
    int p = 1;

    if (M < N)
    {
        for (int k = 0; k < (M + 1) / 2; k++)
        {
            circle(k, M, N, ref matrix, ref nums, ref p);
        }
    }
    else
    {
        for (int k = 0; k < (N + 1) / 2; k++)
        {
            circle(k, M, N, ref matrix, ref nums, ref p);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($"0{matrix[i, j]} ");
            else
                Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = generateFilledSquareMatrix(4, 4);
PrintMatrix(matrix);