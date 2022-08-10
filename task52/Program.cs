// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void FindColumnAverage(int[,] array, int m, int n)
{
    for (int j = 0; j < n; j++)
    {
        double aver = 0;
        double sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += array[i, j];
        }
        aver = sum / m; 
        Console.WriteLine("Среднее арифметическое элементов в {0} столбце равно {1}", j, Math.Round(aver, 1));
    }
}

Console.Write("Введите кол-во строк в массиве: m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: n = ");
int n = int.Parse(Console.ReadLine());

int[,] array = GetArray(m, n);

Console.WriteLine("Заданный массив случайных целых чисел:");
PrintArray(array, m, n);

Console.WriteLine("Примечание: нумерация строк и столбцов массива начинается с 0");
FindColumnAverage(array, m, n);
