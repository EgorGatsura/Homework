Console.WriteLine("Welcome to the program that determines whether the entered number is prime or not");
Console.WriteLine("Enter the number you want to check");
ulong a = Convert.ToUInt64(Console.ReadLine());
if (a >= 2)
{
    if (a == 2 || a == 3 || a == 5 || a == 7)
    {
        Console.WriteLine("This number is prime");
        return;
    }

    if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0 || a % 7 == 0)
    {
        Console.WriteLine("This number is not prime");
    }
    else
    {
        Console.WriteLine("This number is prime");
    }
}
else
{
    Console.WriteLine("The first prime number is two");
}

Console.ReadLine();