//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

 /*int ThreeDigitArray = new int[]; 
 Random rand = new Random();   

    for (int i = 0; i < ThreeDigitArray.Length; i++) 
    {
        ThreeDigitArray [] = rand. Next(100, 1000);
        Console.Write(ThreeDigitArray[]); 
    }

int EnenNumberCount = 0;

for (int i = 0; i < ThreeDigitArray.Length; i++) 
{
    if (ThreeDigitArray [i] % 2 == 0)
}
    {
        EnenNumberCount = ThreeDigitArray [i];
    }

return (EnenNumberCount);
*/

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


/*
int [] newArray = new int [8];
Random rand = new Random ();


for (int i = 0; i < newArray.Length; i++) 
{
    newArray[i] = rand.Next(8, 45);
    Console.WriteLine ("Num["+i+"]=" + newArray[i]);
}

int FindOddIndexSum(int[] array)

int sum = 0;

for (int i = 0; i < newArray.Length; i+=2) 

{
   if newArray [i] % 2 == 1
   sum +=newArray[i];
}
   
Console.WriteLine ("Sum = ");

 Console.ReadLine();

 */


  // Задайте массив вещественных(дробных, см. Random().
  //NextDouble()) чисел.  Найдите разницу между максимальным 
  //и минимальным элементов массива.

double min = double.MaxValue;
double max = double.MinValue;
 
double k;
 
for (int i = 0; i < 4; i++)
{
    Console.Write("Введите {0}-е число: ", i + 1);
    k = double.Parse(Console.ReadLine());
 
    if (k > max)
    max = k;
 
    if (k < min)
    min = k;
}
 
Console.WriteLine("Разница между макс и мин: {0}", max - min);
 
 Console.ReadLine();



