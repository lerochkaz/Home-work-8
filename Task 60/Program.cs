// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] InputSizeArray()
{
    Console.WriteLine("Введите размерность массива по X: 2");
    int x = 2;
    Console.WriteLine("Введите размерность массива по Y: 2");
    int y = 2;
    Console.WriteLine("Введите размерность массива по Z: 2");
    int z = 2;
    int[,,] array = new int[x, y, z];
    return array;
}

void FillArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Random generator = new Random();
        for (int j = 0; j < array.GetLength(1); j++)
        {

            for (int n = 0; n < array.GetLength(2); n++)
            {
                array[i, j, n] = generator.Next(10, 100);
            }
        }

    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write($"{array[i, j, n]} ({i},{j},{n}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] newArray = InputSizeArray();
FillArray(newArray);
PrintArray(newArray);

