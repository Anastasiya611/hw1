//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
int[,] NewArray2(int m, int n)
{
    int[,] a = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = new Random().Next(0, 100);
            Console.Write("{0, 6}", a[i, j]);
        }
        Console.WriteLine();
    }
    return a;
}
Console.WriteLine("Введите количество строк и столбцов первой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] a = NewArray2(m, n);
Console.WriteLine("Введите количество строк и столбцов второй матрицы");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int[,] b = NewArray2(x, y);
if (n != x) Console.WriteLine("произведение матриц невозможно");
else
{
    Console.WriteLine("произведение матриц:");
    int[,] c = new int[m, y];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < y; j++)
        {
            c[i, j] = MatrixComposition(i, j);
            Console.Write("{0, 6}", c[i, j]);
        }
        Console.WriteLine();
    }
}
int MatrixComposition(int k, int l)
{
    int num = 0;
    for (int i = 0; i < a.GetLength(1); i++)
    {
        num += a[k, i] * b[i, l];
    }
    return num;
}