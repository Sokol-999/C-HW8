// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//  элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillArrayWithRandomNumbers(int rows, int cols, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[,] array = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(leftRange, rightRange);
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return array;
}

int[,] array = FillArrayWithRandomNumbers(4, 3, 1, 10);
System.Console.WriteLine();
int[,] array2 = Sort(array);
PrintMatrix(array2);

int[,] Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k+1];
                    array[i, k+1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
