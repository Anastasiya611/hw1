// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
System.Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите четвертое число:");
int d = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите пятое число:");
int f = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите шестое число:");
int g = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите седьмое число:");
int h = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите восьмое число:");
int i = int.Parse(Console.ReadLine()!);
int [] array = {a,b,c,d,f,g,h,i};
Console.WriteLine("[" + string.Join(", ", array) +"]");