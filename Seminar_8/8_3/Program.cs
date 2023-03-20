// Задача 3. Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

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

int[,] MassNums(int row, int column, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(0, to);
    return arr;
}

int[] Frequency(int[,] arr, int to)
{
    int[] dict = new int [to + 1];
    foreach (int element in arr)
    {
        dict[element] += 1;
    }
    return dict;
}

string PrintFrequency(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length - 1; i++)
        {
            res += $"Значение {i} встречается {array[i]} раз\n";
        }
    return res;
}

Console.WriteLine("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальную границу:");
int max = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(rows, columns, max);
Print(mass);
System.Console.WriteLine();
int[] dictionary = Frequency(mass, max);
string result = PrintFrequency(dictionary);
System.Console.WriteLine(result);