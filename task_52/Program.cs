// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("enter the number of rows:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of columns:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
double[] sum = new double[columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(100);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        sum[i] += matrix[j, i];
    }
}
Console.WriteLine();

for (int i = 0; i < columns; i++)
{
    Console.Write((sum[i] / matrix.GetLength(0)) + "\t");
}