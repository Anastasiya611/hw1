// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Строка 1
//Столбец 2
//Вывод: 4
Console.Clear();

void InputMatrix(int[,] matrix)
{
for (int i = 1; i < matrix.GetLength(0); i++)
{
for (int j = 1; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 11);
}
}
}

void PrintMatrix(int[,] matrix)
{
Console.WriteLine();
for (int i = 1; i < matrix.GetLength(0); i++)
{
for (int j = 1; j < matrix.GetLength(1); j++)
Console.Write(matrix[i, j] + " \t");
Console.WriteLine();
}
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.Write("Введите строку: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>n || b>m)
    Console.Write("Такого элемента нет");
    else 
 Console.Write(matrix[a, b]);


