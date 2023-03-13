// Задача 4: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int[,] FillArray (int rows, int columns, int from, int to)
{
    int[,] array = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(from, to);
    }
    return array;
}

void PrintArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();      
}

int[,] CopyArray (int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] newArr = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArr[i, j] = array[i, j];
        } 
    }
    return newArr;
}

Console.WriteLine("Введите количество строк:");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение:");
int max = int.Parse(Console.ReadLine()!);
int[,] massive = FillArray(r, c, min, max);
PrintArray(massive);
int[,] mas = CopyArray(massive);
PrintArray(mas);