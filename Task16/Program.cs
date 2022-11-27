//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
//последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.WriteLine("Введите размер массива: ");
int a = int.Parse(Console.ReadLine()!);
int [] array = new int [a];
Mass(array);
MultMass(array);

//----------------methods---------------------

void Mass(int[] array)
{
    for(int i=0; i<array.Length; i++){
        array[i] = new Random().Next(-100,100);
    }
    Console.WriteLine($"Массив:  [{String.Join(" , ",array)}]");
} 
 
 void MultMass(int[] array)
 {
 int [] mult;
 if (array.Length%2 > 0) {
    mult = new int[array.Length/2+1];
    mult[array.Length/2] = array[array.Length/2];
        
    }
    else {
        mult = new int[array.Length/2];
    }
 
 {  
    int c = 0;
    int i = 0;
    int l = array.Length-1;
    while(i < l)
    {
    mult[c] = array[i] * array[l];
    c++;
    i++;
    l--; 
   }
   
   Console.WriteLine($"Произведения парных элементов:  [{String.Join(" , ",mult)}]");
   }
 }
 
    
   /*int[] m;
    int i = 0;
    int l = array.Length-1;
    while(i < l)
    { 
    int res = array[i] * array[l];
    
    i++;
    l--;
    }
  
  return m;*/


   /*  int c = 0;
    int[] m = new int [array.Length/2];
    int i = 0;
    int l = array.Length-1;
    while(i < l)
    { 
    int res = array[i] * array[l];
    
    {
    m[c] = res;
    c++;
    i++;
    l--; 
    } 
   if(array.Length%2 > 1)
   {
    
    int add = array[array.Length/2];
    int [] mult = new int [(array.Length/2)+1];

   }
    }
   Console.WriteLine($"Массив:  [{String.Join(" , ",m)}]");*/
    
   /*Console.Write("Введите число элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Введите нижнюю границу массива: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите вернюю границу массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
if (size>0 && (minValue < maxValue)){
int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Произведения пар чисел: [ {String.Join(", ", number_multip(array))} ]");
}
else Console.WriteLine("Не коректные входные данные");
int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
int[] number_multip(int[] array){
   int[] array_mulpip = new int[array.Length/2];
   for (int i=0; i<array_mulpip.Length; i++)   {
    array_mulpip[i] = array[i]*array[array.Length-i-1]; 
   }
    return array_mulpip;
}*/