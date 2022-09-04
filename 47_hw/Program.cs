//  Homeworr 7. задача 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// m = 3, n = 4. 
// 0,5 7 -2 -0,2 
// 1 -3,3 8 -9,9 
// 8 7,8 -7,1 9 

Console.Write("Введите m  ");
int m = Convert.ToInt32(Console.ReadLine()); //кол  строк
Console.Write("Введите n  ");
int n = Convert.ToInt32(Console.ReadLine()); //кол столб

double[,] ourMatrix = GetMatrix(m, n, -10, 10);//вызвать написаный метод для какой то матрицы
PrintMatrix(ourMatrix);//вызов метода 
double[,] GetMatrix(int rowsCount, int columnsCount, double leftRange, double rightRange)// метод, парам.: число строк, столб, лев диапаз и прав
{
    double[,] matrix = new double[rowsCount, columnsCount];//подгот матр, создание- назван, память выд new int, указать сколько стр стлб

    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)// GetLength(0) это метод, поэтому скобки, 0 строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble(leftRange, rightRange);//обращ к ячейке матрицы
        }
    }
    return matrix;
}
// Console.WriteLine(string.Join(", ", ourMatrix ));//здесь не работает
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();//перенос строки
    }
}


// Convert.ToDouble(Console.ReadLine());//для веществ