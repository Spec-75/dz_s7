// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Write("Введите номер строки массива от 1 до 4, интересующего элемента: ");
int numberRow = int.Parse(Console.ReadLine()!);
int row = 4;
Console.Write("Введите номер столбца массива от 1 до 4, интересующего элемента: ");
int numberColumn = int.Parse(Console.ReadLine()!);
int BuferI = int.MinValue;
int BuferJ = int.MinValue;
int column = 4;
int[,] matrix = new int[row, column];
Console.WriteLine("matrix:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i == numberRow - 1) BuferI = i;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 11);
        Console.Write(matrix[i, j] + "\t");
        if (j == numberColumn - 1) BuferJ = j;
    }
    Console.WriteLine();
}
if (BuferI == int.MinValue || BuferJ == int.MinValue)
{
    Console.WriteLine($"Элемент с индексами({numberRow}, {numberColumn}) не найден.");
}
else
{
    Console.WriteLine($"Элемент с индексами({numberRow}, {numberColumn}) равен {matrix[BuferI, BuferJ]}");
}