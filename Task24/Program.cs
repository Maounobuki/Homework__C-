// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер
//  строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение элементов массива: ");
int minValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение элементов массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine($" Cтрока №{MinRowsSum(array)} содержит минимальную сумму элементов");

// ------------------Методы-----------------------

// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


// Метод печати двумерного масссива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}



int MinRowsSum(int[,] array)
{
    int sum = 0;
    int  n = 1;
    int[] rowssum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        rowssum[i] = sum;
        sum = 0;
    }
    sum = rowssum[0];
    for (int l = 0; l < rowssum.Length; l++)
    {
        if (rowssum[l] < sum)
        {
            sum = rowssum[l];
            n+= l;
        }
    }
    return n;
}
