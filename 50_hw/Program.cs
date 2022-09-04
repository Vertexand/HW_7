// homework 7 Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 1 7 -> такого числа в массиве нет 

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); //количество строк
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); //количество столбцов
int[,] ourMatrix = GetMatrix(m, n, -10, 10);
PrintMatrix(ourMatrix);
int res = ValueThisElemen(ourMatrix);
Console.WriteLine(res);

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите i ");
int i = Convert.ToInt32(Console.ReadLine()); //количество строк
Console.WriteLine("Введите j ");
int j = Convert.ToInt32(Console.ReadLine()); //количество столбцов

    int ValueThisElement(int[,] matrix)
    {
               if (i <= matrix.GetLength(0) && j <= matrix.GetLength(1))
        {
           res= matrix[i, j]; 
        }
        else
        {
            Console.WriteLine("такого числа в массиве нет");
        }
        return res;
    }