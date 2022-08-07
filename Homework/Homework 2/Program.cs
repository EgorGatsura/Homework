Console.WriteLine("What grade did you get?");
ulong a = Convert.ToUInt64(Console.ReadLine());
if (a <= 10)
{
    if (a <= 2)
    {
        Console.WriteLine("was absent");
    }

    if (a > 2 && a <= 4)
    {
        Console.WriteLine("not satisfactorily");
    }

    if (a > 4 && a <= 6)
    {
        Console.WriteLine("satisfactorily");
    }

    if (a > 6 && a <= 8)
    {
        Console.WriteLine("good");
    }

    if (a > 8 && a <= 10)
    {
        Console.WriteLine("excellent");
    }
}
else
{
    Console.WriteLine("Haha, very funny, there is no such assessment.");
}

Console.ReadLine();