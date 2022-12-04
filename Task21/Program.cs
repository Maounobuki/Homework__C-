// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание,
//что такого элемента нет.
//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

 //i = 5; j = 2 -> такого числа в массиве нет
//i = 1; j = 1 -> 9

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение элементов массива: ");
int minValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение элементов массива: ");
int maxValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите индексы нужного элемента массива: ");
int i = int.Parse(Console.ReadLine()!);
int j = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
SearchArrEl(array, i, j);
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
void SearchArrEl(int[,] array, int i, int j)
{
    if(i>array.GetLength(0)-1||i < 0 || j>array.GetLength(1)-1||j < 0)
    {
    Console.WriteLine("Такого элемента в массиве не существует");
    }
    else
    {
        Console.WriteLine($"Искомый элемент: {array[i,j]}");
    }
    
}