/*Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.*/


Console.WriteLine("Введите числa кординаты А: ");
            double x1 = double.Parse(Console.ReadLine()!);
            double y1 = double.Parse(Console.ReadLine()!);
            double z1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введите числa кординаты B: ");
            double x2 = double.Parse(Console.ReadLine()!);
            double y2 = double.Parse(Console.ReadLine()!);
            double z2 = double.Parse(Console.ReadLine()!);


            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

            Console.WriteLine($"Расстояние между координатами А и B = {AB:f3}" );





/*void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(-100, 100);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
     Console.WriteLine(col[position]);
     position++;
    }
}
int[] array = new int[3];
Console.WriteLine("Координаты случайной точки А");
FillArray(array);
PrintArray(array);
Console.WriteLine();
void FillArray2(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(-100, 100);
        index++;
    }
}
void PrintArray2(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
     Console.WriteLine(col[position]);
     position++;
    }
}
int[] array2 = new int[3];
Console.WriteLine("Координаты случайной точки B");
FillArray2(array2);
PrintArray2(array2);
Console.WriteLine();
double masR = Math.Sqrt(Math.Pow(array[0]-array2[0], 2) + Math.Pow(array[1]- array2[1], 2) + Math.Pow(array[2]- array2[2], 2));
Console.WriteLine($"Расстояние между случайными точками в трёхмерном пространстве: {masR:f2}");*/


