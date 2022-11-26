//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
//элементов,стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).



Console.WriteLine("Введите размер массива: ");
int a = int.Parse(Console.ReadLine()!);
int [] array = new int [a];
Mass(array);
Console.WriteLine($"Массив:  [{String.Join(" , ",array)}]");
Console.WriteLine($"Сумма элементов с нечётными индексами: {OddIndSum(array)}");


//----------------methods---------------------

int[] Mass(int[] array)
{
    for(int i=0; i<array.Length; i++){
        array[i] = new Random().Next(-100,100);
    }
    return array;
} 
 
 int OddIndSum(int[] Mass)
 {
    int sum = 0;
    int i = 0;
    while(i < Mass.Length)
    {
    if (i%2 > 0)
    {
    sum +=Mass[i];
    i++;
    }
    else
    {
    i++;
    }
    }
  return sum;
 }
