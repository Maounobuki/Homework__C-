// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
//арифметическое элементов в каждом столбце. 
//что такого элемента нет.
//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
ColumnsAverage(array, rows, columns);
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
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void ColumnsAverage(int[,] array, int i, int j)
{
    double [] average = new double [array.GetLength(1)];
    double res = 0;
    for( j  = 0; j < array.GetLength(1); j++)
    {
        
    for( i = 0; i < array.GetLength(0); i++){
        res+= array[i,j];
        }
        average[j] = res/array.GetLength(0);
        res = 0;
    }
    Console.WriteLine($"Среднее арифметическое столбцов: [{String.Join(" , ",average)}]");
}
    
