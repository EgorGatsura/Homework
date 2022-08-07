Console.WriteLine("Choose the name of the month");
Console.WriteLine(
    "1 [January] 2 [February] 3 [March] 4 [April] 5 [May] 6 [June] 7 [July] 8 [August] 9 [September] 10 [October] 11 [November] 12 [December]");
ulong a = Convert.ToUInt64(Console.ReadLine());
if (a >= 1 && a <= 12)
{
    switch (a)
    {
        case 1:
            case 2:
                case 12:
            Console.WriteLine("Winter");
            break;
        case 3:
            case 4:
                case 5:
            Console.WriteLine("Spring");
            break;
        case 6:
            case 7:
                case 8:
            Console.WriteLine("Summer");
            break;
        case 9:
            case 10:
                case 11:
            Console.WriteLine("Autumn");
            break;
    }
}
else
{
    Console.WriteLine("I see you are a joker....");
}

Console.ReadLine();