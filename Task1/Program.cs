/*Задача 2: 
Напишите программу, которая на вход принимает два числа и
 выдаёт, какое число большее, а какое меньшее.*/


Console.WriteLine("Введите число 1: ");
int num1 = int.Parse (Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2)
{
Console.WriteLine("Число 1 большее");
Console.WriteLine("Число 2 меньшее");
}
else 
{
Console.WriteLine("Число 2 большее");
Console.WriteLine("Число 1 меньшее");
}
