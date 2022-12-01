//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

Console.WriteLine("Укажите количество вводимых чисел: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество чисел больше 0:  {OverZero(m)}");


//----------------methods---------------------


int OverZero(int lenght)
{
int [] cell = new int [lenght];
int count = 0;
for (int i = 0; i<lenght; i++)
{
    Console.WriteLine("Введите значение: ");
    cell[i] = int.Parse(Console.ReadLine()!);
    if(cell[i]>0)
    {
        count++;
    }
    
}
return count;
}