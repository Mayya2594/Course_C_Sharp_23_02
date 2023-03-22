// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


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

int[] RowSum (int[,] arr)
{
    int result;
    int[] newArr = new int[arr.GetLength(0)];    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        result = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
            result += arr[i, j];
        newArr[i] = result;
    }
    return newArr;
}

void FindMinRowSum (int[] newArr)
{
    int i = 0;
    int minPos = 1;
    int minSum = newArr[i];
    while (i < newArr.Length)
    {
        if(newArr[i] < minSum)
        {
            minSum = newArr[i];
            minPos = i + 1;
        }
        i ++;
    }    
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {minPos}");
}

Console.WriteLine("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine()!);
if(rows == columns)
    System.Console.WriteLine("Необходима прямоугольная матрица, повторите ввод");
else
{
    Console.WriteLine("Введите минимальную границу:");
    int min = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите максимальную границу:");
    int max = int.Parse(Console.ReadLine()!);

    int[,] mass = MassNums(rows, columns, min, max);
    Print(mass);
    int[] newMass = RowSum(mass);
    FindMinRowSum(newMass);
}