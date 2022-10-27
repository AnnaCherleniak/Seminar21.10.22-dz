// 7. Написать программу, которая обменивает элементы первой строки и последней строки

void FillArray(int[,] matrix)
{
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(0, 10);
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
void ReplaseArray(int[,] matrix)
{
    int i = 0;
    int temp = 0;
    int iMax = matrix.GetLength(0) - 1;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[i, j];
        matrix[i, j] = matrix[iMax, j];
        matrix[iMax, j] = temp;
    }
}
Console.WriteLine("Введите количество строк в массиве - ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в массиве - ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Ваш массив - ");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Ваш массив с изменениями - ");
ReplaseArray(matrix);
PrintArray(matrix);