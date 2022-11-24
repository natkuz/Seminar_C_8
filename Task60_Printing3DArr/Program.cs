﻿/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] array = new int[2, 2, 2]
{
    {
        {66, 27},
        {25, 90},
    },
    {    
        {34, 26},
        {41, 55},
    }
};

Print3DArray(array);

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write(array[i, j, k] + "(" + string.Join(", ", i, j, k) + ")" + " ");
            }
            Console.WriteLine();            
        }
    }
}