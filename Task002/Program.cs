// 2. Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
}
void PrintArray(int[,] matrix)
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
int[,] A = new int[m, n];
FillArray(A);
PrintArray(A);