// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 100);
}
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int Max (int[] array)
{
int max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
return max;
}
int Min (int[] array)
{
    int min= array [0];

for (int j = 0; j < array.Length; j++)
    if (array[j] < min)
    {
        min = array[j];
    }
return min;
}
int max = Max(array);
int min = Min(array);
int dif = max - min;

Console.WriteLine(Max(array));
Console.WriteLine(Min(array));
Console.WriteLine(dif);