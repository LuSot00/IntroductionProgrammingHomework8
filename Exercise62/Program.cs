// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetMatrix(int n, int m)
{
    int[,] matr = new int[n, m];
    int number = 1;
    int i = 0;
    for (int k = 0; k < matr.GetLength(1) - 1; k++)
    {
        matr[i, k] = number;
        number++;
    }
    int j = matr.GetLength(1) - 1;
    for (int l = 0; l < matr.GetLength(0) - 1; l++)
    {
        matr[l, j] = number;
        number++;
    }
    i = matr.GetLength(0) - 1;
    for (int k = matr.GetLength(1) - 1; k > 0; k--)
    {
        matr[i, k] = number;
        number++;
    }
    j = 0;
    for (int l = matr.GetLength(0) - 1; l > 1; l--)
    {
        matr[l, j] = number;
        number++;
    }
    i = 1;
    for (int k = 0; k < matr.GetLength(1) - 1; k++)
    {
        matr[i, k] = number;
        number++;
    }
    i = 2;
    for (int k = matr.GetLength(1) - 2; k > 0; k--)
    {
        matr[i, k] = number;
        number++;
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[,] array2D = GetMatrix(4, 4);
PrintMatrix(array2D);