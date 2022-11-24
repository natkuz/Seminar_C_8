/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] firstMatrix = new int[,]
{
    {2, 4, 5},
    {3, 2, 5},
    {1, 1, 1},
};

int[,] secondMatrix = new int[,]
{
    {3, 4, 1},
    {3, 3, 1},
    {1, 1, 1},
};

int[,] productMatrix = ProductOfTwoMatrix(firstMatrix, secondMatrix);
PrintArray(productMatrix);

int[,] ProductOfTwoMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] resultMatrix = new int[matrixTwo.GetLength(1), matrixOne.GetLength(0)]; 
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(0); j++)
        {
            for (int k = 0; k < matrixTwo.GetLength(1); k++)
            {
                resultMatrix[i, k] = resultMatrix[i, k] + matrixOne[i, j] * matrixTwo[j, k];
            }
        }
    }
    return resultMatrix;
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