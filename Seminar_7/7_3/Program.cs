﻿// Задача 3: Задайте двумерный массив. Найдите сумму элементой главной диагонали.

void Print(int[,] arr)
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

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void MainDiagonalSum(int[,] arr)
{
    int sum = 0;
    int num = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == j)
            {
                num = arr[i, j];
                sum += arr[i, j];
                if (j < arr.GetLength(1) - 1) Console.Write($"{num} + ");
                else if (j ==  arr.GetLength(1) - 1) Console.Write($"{num} ");
            }
        }
    Console.Write($"= {sum}");
}


Console.WriteLine("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальную границу:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальную границу:");
int max = int.Parse(Console.ReadLine()!);


int[,] mass = MassNums(rows, columns, min, max);
Print(mass);
MainDiagonalSum(mass);