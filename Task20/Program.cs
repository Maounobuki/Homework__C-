//Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);


double [,] array = GetArray(rows, columns);
PrintArray(array);
// ------------------Методы-----------------------

// Метод создания двумерного массива
double [,] GetArray(int m, int n)
{
    double [,] result = new double [m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++)
        {
            int randomiser = new Random().Next(-1000, 1001);
            result[i,j] = new Random().NextDouble()*randomiser;
        }
    }
    return result;
}


// Метод печати двумерного масссива
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]:f3} ");
        }
        Console.WriteLine();
    }
}