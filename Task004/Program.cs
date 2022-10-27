// 4. В двумерном массиве показать позиции числа, заданного пользователем 
//или указать, что такого элемента нет

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
int FindElementArrayRow(int[,] matrix, int N)
{
    int x = -1;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] == N)
            {
                x = i + 1;
                break;                
            }
        }
    }
    return x;
}
int FindElementArrayColumn(int[,] matrix, int N)
{
    int y = -1;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] == N)
            {
                y = j + 1;
                break;                
            }
        }
    }
    return y;
}

Console.WriteLine("Введите количество строк в массиве - ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в массиве - ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Ваш массив - ");
PrintArray(matrix);
Console.WriteLine("Введите число, которое найти в массиве - ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число {N} находится на строке {FindElementArrayRow(matrix, N)} и столбце {FindElementArrayColumn(matrix, N)}");