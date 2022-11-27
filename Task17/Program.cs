//Задача 38: Задайте массив целых чисел от -10 до 10. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива: ");
int a = int.Parse(Console.ReadLine()!);
int [] array = new int [a];
Mass(array);
Div(array);
Console.WriteLine($"Массив:  [{String.Join(" , ",array)}]");
Console.WriteLine($"Разница между максимальным и минимальным: {Div(array)}");
int[] Mass(int[] array)
{
    for(int i=0; i<array.Length; i++){
        array[i] = new Random().Next(-10,10);
    }
    return array;
} 

int Div(int [] array)
{
int res = 0;
int i = 0;
int max = array[i];
int min = array[i];
while (i < array.Length)
{
 
 if(max < array [i])
 {
max = array[i];
 }
if(min > array [i])
 {
min = array[i];
 }
i++;
}
res = max - min;
return res;
}

/*int res = 0;
int i = 0;
int max = array[i];
int min = array[i];
while (i < array.Length)
{
 
 if(max < array [i])
 {
max = array[i];
 }
if(min > array [i])
 {
min = array[i];
 }
i++;
}
res = max - min;
Console.WriteLine($"{max}");
Console.WriteLine($"{min}");
Console.WriteLine($"{res}");*/