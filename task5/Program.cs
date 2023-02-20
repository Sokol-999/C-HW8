// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray(int rows, int cols)
{

    int[,] array = new int[rows, cols];
    int i = 0; 
    int j = 0;
    int k = 1;

    while (k <= rows * cols)
    {
        array[i, j] = k;
        k++;

        if (i <= j + 1 && (i + j) < cols - 1)
        {
            j++;
        }
        else if (i <= j-1 && (i + j) >= rows - 1)
        {
            i++;
        }
        else if (i >= j && (i + j) > cols - 1)
        {
            j--;
        }
        else
        {
            i--;
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
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = FillArray(4, 4);
PrintArray(array);















