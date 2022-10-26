// 1. Показать двумерный массив размером m×n заполненный вещественными числами

void FillArray(double[,] matrix)
{
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(0, 10) + random.NextDouble();
    }
}
void PrintArray(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк в массиве - ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в массиве - ");
int n = int.Parse(Console.ReadLine() ?? "0");
double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);