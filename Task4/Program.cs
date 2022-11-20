/*Задача 8: Напишите программу, которая на вход 
принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/
Console.WriteLine("Введите число : ");
int num1 = int.Parse (Console.ReadLine()!);

for(int count = 2; count <= num1; count = count+2)
{
Console.WriteLine(count);
}

