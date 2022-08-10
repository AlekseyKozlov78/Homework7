// // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetArray(int m, int n)
{
  double[,] array = new double[m, n];

  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round((new Random().NextDouble()*20 -10),1);
    }    
  }
  return array;
}

void PrintArray (double[,] array, int m, int n)
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

Console.WriteLine("Введите кол-во строк в массиве: m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массиве: n");
int n = int.Parse(Console.ReadLine());

double[,] array = GetArray(m, n);

Console.WriteLine("Заданный массив случайных вещественных чисел:");
PrintArray(array, m, n);
