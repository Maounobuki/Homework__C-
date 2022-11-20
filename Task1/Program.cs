/*Задача 2: 
Напишите программу, которая на вход принимает два числа и
 выдаёт, какое число большее, а какое меньшее.*/


Console.WriteLine("Введите число 1: ");
int num1 = int.Parse (Console.ReadLine()!);

Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()!);

if(num1 > num2)
{
Console.WriteLine($"Первое число {num1} - большее");
Console.WriteLine($"Второе число {num2} - меньшее");
}
else 
{
Console.WriteLine($"Второе число {num2} - большее");
Console.WriteLine($"Первое число {num1} - меньшее");
}
