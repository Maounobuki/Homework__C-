/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
 Обязательна проверка на ввод чисел больше/меньше 3-х знаков*/

 Console.WriteLine("Введите число : ");
int num1 = int.Parse (Console.ReadLine());
string num = num1.ToString();
if(num.Length !=3){
    Console.WriteLine("Неверное число!");
}
else
{
    Console.WriteLine(num[1]);
}