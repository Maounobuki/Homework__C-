//Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран. (числа берете любые)
int[] array = new int[8];
Console.WriteLine("Введите нижний предел: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхний предел: ");
int b = int.Parse(Console.ReadLine()!);
Mass(array, a, b);
Console.WriteLine($"Массив:  [{String.Join(" , ",array)}]");

int[] Mass(int[] array, int min, int max)
{
    for(int i=0; i<array.Length; i++){
        array[i] = new Random().Next(min,max);
    }
    return array;
} 

