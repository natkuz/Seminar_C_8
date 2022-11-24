/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] SortedArrayRowsInDescendingOrder(int[,] array)
{
    int min;
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            min = array[i, 0];
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k + 1] > min)
                {
                    temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                    min = array[i, k + 1];
                }
                else
                {
                    min = array[i, k + 1];
                }
            }
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

int[,] massive = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

int[,] array = SortedArrayRowsInDescendingOrder(massive);
PrintArray(array);