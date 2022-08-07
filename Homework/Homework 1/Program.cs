Console.WriteLine("Enter the length of the first side of the triangle");
ulong a = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine("Enter the length of the second side of the triangle");
ulong b = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine("Enter the length of the third side of the triangle");
ulong c = Convert.ToUInt64(Console.ReadLine());
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