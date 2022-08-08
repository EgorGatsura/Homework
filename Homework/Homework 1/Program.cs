Console.WriteLine("Enter the length of the first side of the triangle");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the length of the second side of the triangle");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the length of the third side of the triangle");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Length of the first side {a}  Length of the second side {b}  Length of the third side {c}");
if (a + b >= c && a + c >= b && c + b >= a && a != 0 && b != 0 && c != 0)
{
    Console.WriteLine("{0}", bool.TrueString);
}
else
{
    Console.WriteLine("{0}", bool.FalseString);
}

Console.ReadLine();