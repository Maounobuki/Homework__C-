// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



Console.WriteLine("Введите длину массива: ");
int lenght = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите высоту столбцов массива: ");
int high = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите ширину массива: ");
int width = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение элементов массива: ");
int minValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение элементов массива: ");
int maxValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Трёхмерный массив: ");
int[,,] array = GetCubeArray(lenght, high, width, minValue, maxValue);
PrintArray(array);


//-------------------methods---------------

int[,,] GetCubeArray(int x, int y, int z, int a, int b)
{
    int[,,] result = new int[x,y,z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++){
                while (true){
                    bool indikator =true;
                    int number = new Random().Next(a, b);
                    foreach(int n in result){
                        if (n == number) indikator = false;
                    }
                    
                    if (indikator == true){
                        result[i,j,k] = number;
                        break;
                    }
                }
            }
            
        }
    }
    return result;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
        Console.WriteLine();
        }
    }
}

