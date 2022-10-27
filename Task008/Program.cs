// 8. В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

Console.WriteLine("Введите количество строк в массиве - ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в массиве - ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Ваш массив - ");
PrintArray(matrix);
int i = 0;
int[] sum = new int[3];
while(i < m)
{
    int j = 0;
    int summ = 0;
    while(j < n)
    {
        summ = summ + matrix[i, j];
        sum[i] = summ;
        j++;
    }
    i++;
}

Console.Write($"Суммы строк - {sum[2]}  ");
Console.WriteLine();

// Console.WriteLine($"Наименьшая сумма элементов в строке - {MinSumRowArray(matrix)}");