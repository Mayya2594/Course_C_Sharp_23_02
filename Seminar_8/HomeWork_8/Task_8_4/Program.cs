// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
            Console.Write($"{arr[i, j]} \t");
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

int FindMinRow(int[,] arr)
{
    int minRow = 0;
    int minNum = arr[minRow, 0];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] < minNum)
            {
                minNum = arr[i, j];
                minRow = i;
            }
        }
    }
    return minRow;
}

int FindMinColumn(int[,] arr)
{
    int minColumn = 0;
    int minNum = arr[0, minColumn];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] < minNum)
            {
                minNum = arr[i, j];
                minColumn = j;
            }
        }
    }
    return minColumn;
}

void PrintNewArr(int[,] arr, int minRow, int MinColumn)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for(int i = 0; i < row; i++)
    {
        if(i != minRow)
        {
            for(int j = 0; j < column; j++)
            {
                if(j != MinColumn)
                    Console.Write($"{arr[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
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
int rowMin = FindMinRow(mass);
int columnMin = FindMinColumn(mass);
Console.WriteLine();
PrintNewArr(mass, rowMin, columnMin);