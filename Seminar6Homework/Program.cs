//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Enter M numbers: ");
int[] array = newArray [];
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Elements > 0: {count}");


//Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного копирования.

/*int CopyArray (int[]array);
{
    int [] array = new int();
    int [] new array = new int[array.Length];
    for (int i = 0;  i < array.Length; i++);
        {
            array[i] = new array[i];
            
        } 
        Console.Write(new array);
}

*/

