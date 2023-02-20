// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArrayWithRandomNumbers(int rows, int cows, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[,] array = new int[rows, cows];

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


void ResultMatrix(int[,] arr1, int[,] arr2, int[,] result)
{
    if (arr1.GetLength(0) == arr2.GetLength(1))
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < arr2.GetLength(1); k++)
                {
                    sum += arr1[i, k] * arr2[k, j];
                }
                result[i, j] = sum;
            }
        }
    }
    else
    {
        System.Console.WriteLine("ERROR");
    }
}

void PrintArray(int[,] array)
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

// int i = 0;
// int j = 0;
// int[,] arr3=new int[arr2.GetLength(0),arr2.GetLength(1)];


// System.Console.Write((arr3[i, j] = arr1[i, j] * arr2[i, j] + arr1[i, j + 1] * arr2[i + 1, j])+"\t");
// System.Console.Write(arr3[i, j+1] = arr1[i, j] * arr2[i, j+1] + arr1[i, j + 1] * arr2[i + 1, j+1]);
// System.Console.WriteLine();
// System.Console.Write((arr3[i+1, j] = arr1[i+1, j] * arr2[i, j] + arr1[i+1, j + 1] * arr2[i + 1, j])+"\t");
// System.Console.Write(arr3[i+1, j+1] = arr1[i+1, j] * arr2[i, j+1] + arr1[i+1, j + 1] * arr2[i + 1, j+1]);

int[,] arr1 = FillArrayWithRandomNumbers(2, 2, 1, 5);
System.Console.WriteLine();
int[,] arr2 = FillArrayWithRandomNumbers(2, 2, 1, 5);
System.Console.WriteLine();
int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
ResultMatrix(arr1, arr2, result);
PrintArray(result);
