Console.WriteLine("Укажите количество вводимых значений: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество значений больше 0:  {OverZero(m)}");


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