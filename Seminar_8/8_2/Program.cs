// Задача 2. Задайте двумерный массив. Напишите программу, которая
// заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.


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

bool Check (int row, int column)
{
    bool result = row != column;
    return result;
}

string Transpon(int[,] arr)
{
    if(Check(arr.GetLength(0), arr.GetLength(1)))
        return "Невозможно транспонировать матрицу";
    for(int i = 1; i < arr.GetLength(0); i++)
        for(int j = 0; j < i; j++)
            (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
    System.Console.WriteLine();
    Print(arr);
    return "Матрица транспонирована";
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
Check(rows, columns);
string result = Transpon(mass);
Console.WriteLine(result);