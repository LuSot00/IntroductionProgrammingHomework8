// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Введите количество строк 1 матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 1 матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк 2 матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 2 матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());


int[,] matrix1 = GetMatrix(rows1, columns1, 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = GetMatrix(rows2, columns2, 0, 10);
PrintMatrix(matrix2);
Console.WriteLine();

if (columns1 != rows2)
{
    Console.WriteLine("Матрицы нельзя перемножить!");
    return;
}

Console.WriteLine("Произведение матриц:");
PrintMatrix(MatricesProduct(matrix1, matrix2));


int[,] GetMatrix(int n, int m, int min, int max)
{
    int[,] matr = new int[n, m];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
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

int[,] MatricesProduct(int[,] arr1, int[,] arr2)
{
    int product = 0;
    int[,] newMatrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int m = 0; m < arr2.GetLength(1); m++)
        {
            int k = 0;
            int l = m;
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                product = product + arr1[i, j] * arr2[k, l];
                k++;
            }
            newMatrix[i, m] = product;
            product = 0;
        }
    }
    return newMatrix;
}