// 3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillArray(int[,] matrix)
{
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 10);
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

void ReplaceElementsArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
                
            }
        }
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
ReplaceElementsArray(matrix);
Console.WriteLine("Массив с изменениями - ");
PrintArray(matrix);