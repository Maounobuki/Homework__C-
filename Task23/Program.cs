// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение элементов массива: ");
int minValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение элементов массива: ");
int maxValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Исходный массив: ");
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);

Console.WriteLine("Отсортированный массив: ");
int [ , ] sarr = GetSortArray(array);
PrintArray(sarr);
GetSortArray(array);

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

int[,] GetSortArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        if (array[i, k] < array[i, j])
        {
            int temp = array[i, j];
            array[i, j] = array[i , k];
            array[i, k] = temp;
        }
    }
}
return array;
}