// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//  Console.WriteLine("Введите число 1");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int b=Convert.ToInt32(Console.ReadLine());

// if (a>b)
// {
// Console.WriteLine($"Число {a} больше числа {b}");

// }
// else
// {
//    Console.WriteLine($"Число {a} меньше числа {b}");
// }

//---------------------------------------------------------------------------------------------

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int c=Convert.ToInt32(Console.ReadLine());

int max=a;

if (a>b)
{
max=a;
}  
else 
max=b;
if (b>c)
{
max=b;
}
else
max=c;

Console.WriteLine($"Число {max} является максимальным");

