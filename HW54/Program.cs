// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
int[,] NewArray2(int m, int n)
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
void PrintArray2(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0, 6}", a[i, j]);
        }
        Console.WriteLine();
    }
}
void SortRows(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1) - 1; j++)
        {
            if (a[i, j] < a[i, FindMax(a, i, j + 1)])
            {
                int temp = a[i, j];
                a[i, j] = a[i, FindMax(a, i, j + 1)];
                a[i, FindMax(a, i, j + 1)] = temp;
            }
        }
    }
}
int FindMax(int[,] a, int k, int l)
{
    int maxNum = l;
    int max = a[k, l];
    for (int i = l + 1; i < a.GetLength(1); i++)
    {
        if (a[k, i] > max)
        {
            maxNum = i;
            max = a[k, i];
        }
    }
    return maxNum;
}
Console.WriteLine("Введите количество строк и столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] a = NewArray2(m, n);
Console.WriteLine("новый массив:");
SortRows(a);
PrintArray2(a);