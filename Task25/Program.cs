// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18






/*Console.WriteLine("Введите количество строк 1й матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов 1й матрицы: ");
int columns1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк 2й матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов 2й матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);

if (columns1 != rows2)

{
Console.WriteLine("Операция невыполнима, введены неверные параметры матриц");
return;
}

Console.WriteLine("Введите минимальное значение элементов матриц: ");
int minValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение элементов матриц: ");
int maxValue = int.Parse(Console.ReadLine()!);
int[,] array1 = GetArray(rows1, columns1, minValue, maxValue);
Console.WriteLine("Матрица 1: ");
PrintArray(array1);
int[,] array2 = GetArray(rows2, columns2, minValue, maxValue);
Console.WriteLine("Матрица 2: ");
PrintArray(array2);
int matrrows = 0;
int matrcolumns = 0;
MatrixLenght(array1,array2,matrrows,matrcolumns);
Console.WriteLine("Результирующая матрица: ");
int[,] mult = MatrixMult(array1, array2, matrrows, matrcolumns);
PrintArray(mult);
// ------------------Методы-----------------------

// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] mult = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            mult[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return mult;
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

void MatrixLenght(int[,] array, int[,] arr, int a, int b)
{
if (array.GetLength(0) > arr.GetLength(0))
{
a = array.GetLength(0);
}
else {a = arr.GetLength(0);}

if (array.GetLength(1) > arr.GetLength(1))
{
b = array.GetLength(1);
}
else {b = arr.GetLength(1);}
}


int[,] MatrixMult(int[,] array, int[,] arr, int a, int b)
{
    int[,] mult = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            int sum = 0;
            for (int x = 0; x < mult.GetLength(0); x++)
            {
                sum += array[i, x] * arr[x, j];
            }
            mult[i, j] = sum;
            sum = 0;
        }
    }
    return mult;
}*/

Console.WriteLine("Введите размер 1й матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);
int columns1 = rows1;

Console.WriteLine("Введите размер 2й матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);
int columns2 = rows2;


if (columns1 != rows2 || columns2 != rows1)

{
Console.WriteLine("Операция невыполнима, введены неверные параметры матриц");
return;
}
Console.WriteLine("Введите минимальное значение элементов матриц: ");
int minValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение элементов матриц: ");
int maxValue = int.Parse(Console.ReadLine()!);
int[,] array1 = GetArray(rows1, columns1, minValue, maxValue);
Console.WriteLine("Матрица 1: ");
PrintArray(array1);
int[,] array2 = GetArray(rows2, columns2, minValue, maxValue);
Console.WriteLine("Матрица 2: ");
PrintArray(array2);

Console.WriteLine("Результирующая матрица: ");
int[,] mult = MatrixMult(array1, array2);
PrintArray(mult);

// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] mult = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            mult[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return mult;
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


int[,] MatrixMult(int[,] array, int[,] arr)
{
    int[,] mult = new int[array.GetLength(0), array.GetLength(1)];
    
    for (int i = 0; i < mult.GetLength(0); i++)
    {
        for (int j = 0; j <mult.GetLength(1); j++)
        {
            int sum = 0;
            for (int x = 0; x < mult.GetLength(0); x++)
            {
                sum += array[i, x] * arr[x, j];
            }
            mult[i, j] = sum;
            sum = 0;
        }
    }
    return mult;
}