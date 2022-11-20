/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).*/
 Console.WriteLine("Введите пятизначное число : ");
int num1 = int.Parse (Console.ReadLine()!);
string num = num1.ToString();
if(num.Length !=5)
{
    Console.WriteLine("Неверное число!");
}
else
{
    if(num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine("Является");
    }
    else
    {
        Console.WriteLine("Не является");
    }
}


//math method

 /*Console.WriteLine("Введите пятизначное число : ");
int num1 = int.Parse (Console.ReadLine()!);
if(num1 < 10000 || num1 > 100000)
{
    Console.WriteLine("Неверное число!");
}
else
{
    if(num1/10000 == num1%10 && (num1 %100)/10 == (num1/1000)%10)
    {
        Console.WriteLine("Является");
    }
    else
    {
        Console.WriteLine("Не является");
    }
}*/