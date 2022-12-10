// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Введите количество строк массива: ");
 int rows = int.Parse(Console.ReadLine()!);

 Console.WriteLine("Введите количество столбцов массива: ");
 int columns = int.Parse(Console.ReadLine()!);
 int[,] array = GetArray( rows, columns);
PrintArray(array);


//Метод заполнения спирального заполнения массива
int[,] GetArray(int n, int m)
{
    int[,] arr = new int[n, m];
    for (int number = 1, prevrow = 0, endrow = n-1,
            prevcol = 0, endcol = m-1; 
            number <= arr.GetLength(0)*arr.GetLength(1); )
    {
        for(int i = prevrow, j = prevcol; j <= endcol; j++){
            arr[i,j] = number;                                               
            number++;
        }
        prevrow ++;                                                         
        if (number > arr.GetLength(0)*arr.GetLength(1)) break;
        
        for(int i = prevrow, j = endcol; i <= endrow; i++){
            arr[i,j] = number;                                               
            number++;
        }
        endcol --;                                                      
        if (number > arr.GetLength(0)*arr.GetLength(1)) break;
        
        for(int i = endrow, j = endcol; j >= prevcol; j--){
            arr[i,j] = number;                                               
            number++;
        }
        endrow --;                                                         
        if (number > arr.GetLength(0)*arr.GetLength(1)) break;
        
        for(int i = endrow, j = prevcol; i >= prevrow; i--){
            arr[i,j] = number;                                               
            number++;
        }
        prevcol ++;                                                      
    }
    return arr;
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