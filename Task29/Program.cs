// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if(M>N) 
{
Console.WriteLine("Недопустимое значение");
 return;
 }
Console.WriteLine(PrintNumbers(M,N));

int PrintNumbers(int M, int N){

    if (M==N) return M;
    return(M += PrintNumbers(M + 1, N));
}