/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] FillArrayInSpiral(int[,] squareArray)
{
    int row = 0;
    int column = -1;
    int movingInRow = 0;
    int movingInColumn = 1;
    int sizeArray = squareArray.GetLength(0);
    int i = 1;
    while (i <= sizeArray * sizeArray)
    {
        if (row + movingInRow >= 0 &&
            row + movingInRow < sizeArray &&
            column + movingInColumn >= 0 &&
            column + movingInColumn < sizeArray &&
            squareArray[row + movingInRow, column + movingInColumn] == 0)
            {
                row = row + movingInRow;
                column = column + movingInColumn;
                squareArray[row, column] = i;
                i++;
            }
        else
        {
            if (movingInColumn == 1)
            {
                movingInColumn = 0;
                movingInRow = 1;
            }
            else if (movingInRow == 1)
            {
                movingInRow = 0;
                movingInColumn = -1;
            }
            else if (movingInColumn == -1)
            {
                movingInColumn = 0;
                movingInRow = -1;
            }
            else if (movingInRow == -1)
            {
                movingInRow = 0;
                movingInColumn = 1;
            }
        }
    }
    return squareArray;
}

void Print2DArray(int[,] array)
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

int[,] massive = new int[4, 4];
int[,] massiveFiiledInSpiral = FillArrayInSpiral(massive);
Print2DArray(massiveFiiledInSpiral);