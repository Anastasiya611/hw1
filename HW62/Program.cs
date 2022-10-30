// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
void FillMatrix(int[,] a)
{
    int k = 1;
    int i = 0;
    int j = 0;
    while (k <= 16)
    {
        while ((j <= 3) & (a[i, j] == 0))
        {
            a[i, j] = k;
            k++;
            if ((j < 3) && (a[i,j+1]==0))
                j++;
        }
        i++;
        while ((i < 3) && (a[i, j] == 0))
        {
            a[i, j] = k;
            k++;
            if ((i<3) && (a[i+1, j] == 0)) i++;
        }
        if (j==2) j--;
        while ((j > 0) && (a[i, j] == 0))
        {
            a[i, j] = k;
            k++;
            if ((j>0) && (a[i, j-1]==0)) j--;
        }
        if (j == 0)
        {
            while ((i > 1) & (a[i, j] == 0))
            {
                a[i, j] = k;
                k++;
                if (i>1)i--;
            }
        }
    }
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
int[,] a = new int[4, 4];
FillMatrix(a);
PrintArray2(a);
