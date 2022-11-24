/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[] ArrayOfRowSum(int[,] array)
{
    int sum = 0;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] arrayOfRowSum = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum = sum + array[i, j];
        }
        arrayOfRowSum[i] = sum;
        sum = 0;
    }
    return arrayOfRowSum;
}

void PrintRowOfArrayWithMinSumElements(int[] array)
{
    int min = array[0];
    int indexMin = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i + 1] < min)
        {
            min = array[i + 1];
            indexMin = i + 1;
        }
    }
    System.Console.WriteLine($"номер строки с наименьшей суммой элементов: {indexMin + 1}");
}

int[,] massive = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {1, 1, 1, 1},
    {9, 2, 6, 9},
};

int[] sumElementsOfRows = ArrayOfRowSum(massive);
PrintRowOfArrayWithMinSumElements(sumElementsOfRows);
