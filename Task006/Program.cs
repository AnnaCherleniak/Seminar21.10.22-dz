// 6. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void FillArray(int[,] matrix)
{
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(0, 10);
    }
}
void PrintArrayTwo(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}
int AverageElementsColumnArray(int[,] matrix, int j)
{
    int aver = 0;
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
        sum += matrix[i, j];
        aver = sum/matrix.GetLength(0);
    return aver;
}
void PrintArrayOne(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
Console.WriteLine("Введите количество строк в массиве - ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в массиве - ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Ваш массив - ");
PrintArrayTwo(matrix);
int[] average = new int[n];
for(int i = 0; i < average.Length; i++)
{
    average[i] = AverageElementsColumnArray(matrix, i);
}
Console.WriteLine("Среднее арифметическое значение каждого столбца - ");
PrintArrayOne(average);
