// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите третье число: ");
int numberС = int.Parse(Console.ReadLine()!);
int max = numberA;

if (numberB > max)
{
    max = numberB;
}
if (numberС > max)
{
    max = numberС;
}
Console.WriteLine (max);

