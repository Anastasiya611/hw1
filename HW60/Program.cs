// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
Console.Clear();
int[,,] NewArray2(int m, int n, int o)
{
    int[,,] a = new int[m, n, o];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < o; k++)
            {
                int num = new Random().Next(10, 100);
                while (IsInArray(num, i, j, k, a) == true)
                {
                    num = new Random().Next(10, 100);
                }
                a[i, j, k] = num;
                Console.Write("[{0, 2},{1, 2},{2, 2}]{3, 3} ", i, j, k, a[i, j, k]);
            }
            Console.WriteLine();
        }
    }
    return a;
}
Console.WriteLine("Введите количество строк, столбцов и уровней массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int o = Convert.ToInt32(Console.ReadLine());
if (m * n * o <= 90) // массив из разных 2-значных чисел, поэтому их не более 90
{
    int[,,] a = NewArray2(m, n, o);
}
else Console.WriteLine("невозможно задать массива данного размера с уникальными 2-значными числами");
bool IsInArray(int x, int y, int b, int c, int[,,] a) // есть ли в массиве а эл-т х стоящий до текущего индекса (y,b,c)
{
    bool flag = false;
    for (int i = 0; i <= y; i++)
    {
        for (int j = 0; j <= b; j++)
        {
            for (int k = 0; k < a.GetLength(2); k++)
            {
                if ((a[i, j, k] == x) & (i <= y) & (j <= b) & (k <= c)) // проверка равенства эл-та и индекса в пределах зоны поиска
                {
                    flag = true;
                    break;
                }
            }

        }
    }

    return flag;
}
