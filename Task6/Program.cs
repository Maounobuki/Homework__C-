/*Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 Берем числа до 100000*/
 Console.WriteLine("Введите число : ");
int num1 = int.Parse (Console.ReadLine()!);
string num = num1.ToString();
if(num.Length < 3){
    Console.WriteLine("Вы ввели неверное число");
}
else
{
    Console.WriteLine(num[2]);
}
