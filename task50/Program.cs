/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/


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

void CheckElement(int[,] array, int i, int j, int m, int n)
{
    if (i < m && i >= 0 && j < n && j >= 0) Console.WriteLine("Значение элемента на позиции [{0}, {1}] равно {2}", i, j, array[i, j]);
    else Console.WriteLine("Элемент с позицией [{0}, {1}] отсутствует в массиве", i, j);
}



Console.Write("Введите кол-во строк в массиве: m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: n = ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Примечание: нумерация строк и столбцов массива начинается с 0");
Console.Write("Введите номер строки искомого элемента: i = ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите номер строки искомого элемента: j = ");
int j = int.Parse(Console.ReadLine());

int[,] array = GetArray(m, n);

Console.WriteLine("Заданный массив случайных чисел:");
PrintArray(array, m, n);

CheckElement(array, i, j, m, n);
