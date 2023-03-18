// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

double[,] MassNums(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];
    Random newRand = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(newRand.NextDouble() * (to - from) + from, 2);
    return arr;
}

Console.WriteLine("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальную границу:");
double min = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальную границу:");
double max = double.Parse(Console.ReadLine()!);


double[,] mass = MassNums(rows, columns, min, max);
Print(mass);