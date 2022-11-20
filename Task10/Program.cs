/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/
Console.WriteLine("Введите число N: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Таблица кубов до числа N: ");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
