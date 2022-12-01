//Задача 43: Написать программу, которая на вход принимает массив из любого 
//количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит 
//этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).


Console.WriteLine("Введите размер массива: ");
int a = int.Parse(Console.ReadLine()!);
int [] array = new int [a];
Mass(array);
Console.WriteLine($"Массив:  [{String.Join(" , ",array)}]");
Sort(array);
Console.WriteLine($"Отсортированный массив: [{String.Join(" , ",Sort(array))}]");
int[] Mass(int[] array)
{
    for(int i=0; i<array.Length; i++){
        array[i] = new Random().Next(0,101);
    }
    return array;
} 
int [] Sort(int [] array)
{
int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }                   
                }            
            }
            return array;
}

