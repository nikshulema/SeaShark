/*
int number;
int current = 0;

Console.Write("Input five-digit number: ");
number = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < number.Length(); i++)
{
    if (number [i] == number [number.Length()- 1 - i]);
    {
        current++;
    }
}

if (current == number.Length())
{
    Console.WriteLine("This is palindrome");
}

else 
{
    Console.WriteLine ("This isn't palindrome");
}
*/



/*void Cube (int x)
{
    int current = 1;
    while (current <= x)
    {
        Console.Write((current*current*current) + " ");
        current ++;
    }

}

Console.WriteLine("Enter number: ");
int x = Convert.ToInt32(Console.ReadLine());

Cube (x);
*/



double Find3D (double xA, double yA, double xB, double yB, double zA, double zB); 
{
    return Math.Sqrt(Math.Pow ((xB - xA), 2) + Math.Pow ((yB - yA), 2) + Math.Pow ((zB - zA), 2));
}
???