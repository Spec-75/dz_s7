// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("enter the number of rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[rows,columns];
Console.WriteLine("matrix:");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = Math.Round(new Random().NextDouble()*100, 2);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}