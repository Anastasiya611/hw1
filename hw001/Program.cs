// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    Console.WriteLine ("max=" + numberA);
    Console.WriteLine ("min=" + numberB);
}
else
{
    Console.WriteLine ("max=" + numberB );
    Console.WriteLine ("min=" + numberA);
}
        
