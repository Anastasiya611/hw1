// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
int[,] newArray2(int m, int n)
{
    int[,] a = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = new Random().Next(-100, 100);
            Console.Write("{0, 6}", a[i, j]);
        }
        Console.WriteLine();
    }
    return a;
}
Console.WriteLine("Введите количество строк и столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] a = newArray2(m, n);
int SumRow(int k)
{
    int sum = 0;
    for (int i = 0; i < a.GetLength(1); i++)
    {
        sum += a[k, i];
    }
    return sum;
}
int minSum = SumRow(0);
int minRow = 0;
for (int i = 1; i < a.GetLength(0); i++)
{
    if (SumRow(i) < minSum)
    {
        minRow = i;
        minSum = SumRow(i);
    }
}
Console.WriteLine($"минимальная сумма в {minRow + 1}-й строке");