﻿// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, 
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array = new int[2, 2, 2];

Random rand = new Random((int)DateTime.Now.Ticks);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int z = 0; z < array.GetLength(2); z++)
        {
            array[i,j,z]= rand.Next(10,100);
            System.Console.Write($"{array[i, j, z]}({i},{j},{z}) ");
        }
        System.Console.WriteLine();
    }
}

