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
int SumElementsRowArray(int[,] matrix, int i)
{
    int summ = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
        summ = summ + matrix[i, j];
    return summ;
}
int MinElementIndex(int[] array)
{
    int min = array[0];
    int iMin = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            iMin = i;
        }
    }
    return iMin;
}


Console.WriteLine("Введите количество строк в массиве - ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в массиве - ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Ваш массив - ");
PrintArray(matrix);
int[] sum = new int[m];
for(int i = 0; i < m; i++)
    sum[i] = SumElementsRowArray(matrix, i);
int iMin = MinElementIndex(sum);
Console.WriteLine($"Строка с минимальной суммой - {iMin}  ");

