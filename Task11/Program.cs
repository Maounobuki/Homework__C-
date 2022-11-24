/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B. 
(Задачи, решенные через Math.Pow,
 будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)*/

Console.WriteLine("Введите основание: ");
 int x = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите показатель степени: ");
 int y = int.Parse(Console.ReadLine()!);
 Console.WriteLine($"Результат: {Pow(x,y)}");

//--------------------------------------------------------- method

 int Pow(int basis, int rank)
 {
    int result = basis;
    int count = 0;
    while(count < rank - 1)
    {
result = result * basis;
count++;
    }
    return result;
 }

