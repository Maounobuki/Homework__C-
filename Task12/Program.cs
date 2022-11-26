/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.*/

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат: {StringSum(a)}");

// ------------------методы-----------------------
 int StringSum(int check)
 {
    string deg = Convert.ToString(check);
    int sum = 0; 
       for(int count = 0; count < deg.Length; count++)
      
    {
        int inc = Convert.ToInt32(deg[count]-48);
         sum +=inc;
    }

return sum;

 }



/*int MathSum(int check)
{
int inc = 0;
int res = 0;
while(check>0)
{
    inc = check%10;
    res+=inc;
    check/=10;
}
return res;
}*/
