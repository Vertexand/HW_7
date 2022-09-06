//  Homeworr 7. задача 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// m = 3, n = 4. 
// 0,5 7 -2 -0,2 
// 1 -3,3 8 -9,9 
// 8 7,8 -7,1 9 

Console.Write("Введите m  ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите n  ");
int n = Convert.ToInt32(Console.ReadLine()); 

double[,] ourMatrix = GetMatrix(m, n, -10, 10);//вызвать написаный метод для какой то матрицы
PrintMatrix(ourMatrix);//вызов метода 
double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    double[,] matrix = new double[rowsCount, columnsCount]; 

    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //  matrix[i, j] = ((rightRange + 1 - leftRange) * rand.NextDouble() + leftRange);//то же работает
            matrix[i, j] = rand.NextDouble() * rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)//строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(Math.Round(matrix[i, j], 1) + " ");//1 зн после зап
        }
        Console.WriteLine();//перенос строки
    }
}


// Convert.ToDouble(Console.ReadLine());//для веществ чисел