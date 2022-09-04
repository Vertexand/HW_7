// homework 7 Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце. Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3. 

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); //количество строк
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); //количество столбцов
int[,] ourMatrix = GetMatrix(m, n, -10, 10);
PrintMatrix(ourMatrix);
average(ourMatrix);


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
void average(int[,] matrix)//метод сред ариф по стобцам
{
    for (int i = 0; i < matrix.GetLength(0); i++)//строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//столбцы
        {
            ArithmeticMean = (matrix[i, j] + matrix[i, j]) / matrix.GetLength(0);//перебор только строк i
        }
        Console.WriteLine(string.Join(", ", ArithmeticMean));
    }
}




// Console.Write("Введите произвольно числа через пробел: ");
// string str = Console.ReadLine();
// string[] arrStr = str.Split();
// int[] numbers = arrStr.Select(int.Parse).ToArray(); //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// int count = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         count++;
//     }
// }
// // Console.WriteLine(string.Join(", ", numbers));
// Console.WriteLine($"Всего чисел больше 0: {count}");