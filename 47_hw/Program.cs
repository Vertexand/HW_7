//  Homeworr 7. Задача 47: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19 
// 5 -2 33 -2 
// 77 3 8 1

Console.Write("Введите m  ");
int m = Convert.ToInt32(Console.ReadLine()); //кол  строк
Console.Write("Введите n  ");
int n = Convert.ToInt32(Console.ReadLine()); //кол столб

int[,] ourMatrix = GetMatrix(m, n, -10, 10);//вызвать написаный метод для какой то матрицы
PrintMatrix(ourMatrix);//вызов метода 
int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)// метод, парам. число строк, столб, лев диапаз и прав
{
    int[,] matrix = new int[rowsCount, columnsCount];//подгот матр, создание- назван, память выд new int, указать сколько стр стлб

    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)// GetLength(0) это метод, поэтому скобки, 0 строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);//обращ к ячейке матрицы
        }
    }
    return matrix;
}
// Console.WriteLine(string.Join(", ", ourMatrix ));//здесь не работает
void PrintMatrix(int[,] matrix)
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
