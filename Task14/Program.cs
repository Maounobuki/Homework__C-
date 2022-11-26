/*Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.*/


Console.WriteLine("Введите размер массива: ");
int a = int.Parse(Console.ReadLine()!);
int [] array = new int [a];
Mass(array);
Console.WriteLine($"Массив:  [{String.Join(" , ",array)}]");
Console.WriteLine($"Количество чётных элементов: {EvenCount(array)}");


//-------------------methods--------------------------------



int[] Mass(int[] array)
{
    for(int i=0; i<array.Length; i++){
        array[i] = new Random().Next(100,1000);
    }
    return array;
} 

 
 int EvenCount(int[] Mass)
 {
    int count = 0;
    int index = 0;
   while(index<Mass.Length)
    {
   if(array[index]%2 == 0)
   {
    count++;
    index++;
   }
   else
   {
    index++;
   }
    }
    return count;
 }