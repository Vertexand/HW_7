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
Console.WriteLine("Введите i");
int i = Convert.ToInt32(Console.ReadLine()); //  адрес стр
Console.WriteLine("Введите j");
int j = Convert.ToInt32(Console.ReadLine()); //  адрес столб
int[,] ourMatrix = GetMatrix(m, n, -10, 10);
PrintMatrix(ourMatrix);
// ValueThisElement(ourMatrix);

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
    if (i >= m && j >= n)
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"значение элемента на указанной позиции = {matrix[i, j]} ");
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
// Console.WriteLine("Введите i ");  //хочу доделать этот вариант, но ума не приложу как
// int i = Convert.ToInt32(Console.ReadLine()
// Console.WriteLine("Введите j ");
// int j = Convert.ToInt32(Console.ReadLine()); 

// void ValueThisElement(int[,] matrix)// как то включить сюда i и j? или ????
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (i <= matrix.GetLength(0) && j <= matrix.GetLength(1))
//             {
//                 Console.WriteLine($"значение элемента на указанной позиции = {matrix[i, j]} ");
//             }
//             else
//             {
//                 Console.WriteLine("такого числа в массиве нет");
//             }
//         }
//     }
// }

