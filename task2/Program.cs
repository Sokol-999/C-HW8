// Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой
//  строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumOfSring(int[,] array)
{
    int sum = 0;
    int k = 0;
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        arr[k] = sum;
        k++;
        System.Console.WriteLine($"Sum of the {i + 1} string: {sum}");
        string text = Convert.ToString(sum);
    }
    return arr;
}

int Minimim(int[] array)
{
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


int[,] array = FillArrayWithRandomNumbers(5, 3, 100, 1000);
System.Console.WriteLine();
int[] arrayStr = SumOfSring(array);
System.Console.WriteLine();
int min = Minimim(arrayStr);
System.Console.WriteLine("Min: " + Minimim(arrayStr));
System.Console.WriteLine();
System.Console.WriteLine("String with min sum of elements: " + Array.IndexOf(arrayStr, min));
System.Console.WriteLine();


