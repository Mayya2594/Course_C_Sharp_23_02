// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixMultiplication (int[,] arr1, int[,] arr2)
{
    int row1 = arr1.GetLength(0);
    int column1 = arr1.GetLength(1);
    int row2 = arr2.GetLength(0);
    int column2 = arr2.GetLength(1);
    int res;
    int[,] resArr = new int[row1, column2];
    for(int i = 0; i < row1; i++)
    {    
        for(int j = 0; j < column2; j++)
        {
            res = 0;
            for(int k = 0; k < row2; k++)
            {    
                res += arr1[i, k] * arr2[k, j];
                Console.WriteLine($"res = {arr1[i, k]}*{arr2[k, j]} = {arr1[i, k] * arr2[k, j]}");
            }
            resArr[i, j] = res;
            Console.WriteLine($"resArr[{i}, {j}] = {res}");
            Console.WriteLine();
        }
    }
    return resArr;
}

Console.WriteLine("Введите количество строк 1:");
int rows1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов 1:");
int columns1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк 2:");
int rows2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов 2:");
int columns2 = int.Parse(Console.ReadLine()!);
if(rows1 != columns2) Console.WriteLine("Матрицы не согласованы, повторите ввод");
else
{
    Console.WriteLine("Введите минимальную границу:");
    int min = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите максимальную границу:");
    int max = int.Parse(Console.ReadLine()!);

    int[,] mass1 = MassNums(rows1, columns1, min, max);
    Print(mass1);
    Console.WriteLine();
    int[,] mass2 = MassNums(rows2, columns2, min, max);
    Print(mass2);
    Console.WriteLine();
    int[,] resMass = MatrixMultiplication(mass1, mass2);
    Print(resMass);
}