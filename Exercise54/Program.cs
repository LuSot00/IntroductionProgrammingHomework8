// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


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

int[,] ArrangeNumbers(int[,] arr)
{
    int[] array = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[j] = arr[i, j];
        }

        Array.Sort(array);
        Array.Reverse(array);

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = array[j];
        }
    }
    return arr;
}

int[,] result = GetMatrix(rows, columns, 0, 10);
PrintMatrix(result);
Console.WriteLine();
Console.WriteLine("Упорядоченный по строчкам массив: ");
PrintMatrix(ArrangeNumbers(result));