Console.WriteLine("Choose the name of the month");
Console.WriteLine(
    "1 [January] 2 [February] 3 [March] 4 [April] 5 [May] 6 [June] 7 [July] 8 [August] 9 [September] 10 [October] 11 [November] 12 [December]");
ulong a = Convert.ToUInt64(Console.ReadLine());
if (a >= 1 && a <= 12)
{
    switch (a)
    {
        case 1:
            Console.WriteLine("Winter");
            break;
        case 2:
            Console.WriteLine("Winter");
            break;
        case 3:
            Console.WriteLine("Spring");
            break;
        case 4:
            Console.WriteLine("Spring");
            break;
        case 5:
            Console.WriteLine("Spring");
            break;
        case 6:
            Console.WriteLine("Summer");
            break;
        case 7:
            Console.WriteLine("Summer");
            break;
        case 8:
            Console.WriteLine("Summer");
            break;
        case 9:
            Console.WriteLine("Autumn");
            break;
        case 10:
            Console.WriteLine("Autumn");
            break;
        case 11:
            Console.WriteLine("Autumn");
            break;
        case 12:
            Console.WriteLine("Winter");
            break;
    }
}
else
{
    Console.WriteLine("I see you are a joker....");
}

Console.ReadLine();