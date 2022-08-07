Console.WriteLine("Enter a number from 0 to 100");
ulong a = Convert.ToUInt64(Console.ReadLine());
if (a <= 100)
{
    if (a == 0)
    {
        Console.WriteLine("Zero");
    }

    if (a == 1)
    {
        Console.WriteLine("One");
    }

    if (a == 2)
    {
        Console.WriteLine("Two");
    }

    if (a == 3)
    {
        Console.WriteLine("Three");
    }

    if (a == 4)
    {
        Console.WriteLine("Four");
    }

    if (a == 5)
    {
        Console.WriteLine("Five");
    }

    if (a == 6)
    {
        Console.WriteLine("Six");
    }

    if (a == 7)
    {
        Console.WriteLine("Seven");
    }

    if (a == 8)
    {
        Console.WriteLine("Eight");
    }

    if (a == 9)
    {
        Console.WriteLine("Nine");
    }

    if (a == 10)
    {
        Console.WriteLine("Ten");
    }

    if (a == 11)
    {
        Console.WriteLine("Eleven");
    }

    if (a == 12)
    {
        Console.WriteLine("Twelve");
    }

    if (a >= 13 && a <= 19)
    {
        switch (a)
        {
            case 13:
                Console.WriteLine("Thirteen");
                break;
            case 14:
                Console.WriteLine("Fourteen");
                break;
            case 15:
                Console.WriteLine("Fifteen");
                break;
            case 16:
                Console.WriteLine("Sixteen");
                break;
            case 17:
                Console.WriteLine("Seventeen");
                break;
            case 18:
                Console.WriteLine("Eighteen");
                break;
            case 19:
                Console.WriteLine("Nineteen");
                break;
        }
    }

    if (a / 10 == 2)
    {
        Console.Write("Twenty");
    }

    if (a / 10 == 3)
    {
        Console.Write("Thirty");
    }

    if (a / 10 == 4)
    {
        Console.Write("Forty");
    }

    if (a / 10 == 5)
    {
        Console.Write("Fifty");
    }

    if (a / 10 == 6)
    {
        Console.Write("Sixty");
    }

    if (a / 10 == 7)
    {
        Console.Write("Seventy");
    }

    if (a / 10 == 8)
    {
        Console.Write("Eighty");
    }

    if (a / 10 == 9)
    {
        Console.Write("Ninety");
    }

    if (a % 10 == 1 && a != 11)
    {
        Console.WriteLine(" One");
    }

    if (a % 10 == 2 && a != 12)
    {
        Console.WriteLine(" Two");
    }

    if (a % 10 == 3 && a != 13)
    {
        Console.WriteLine(" Three");
    }

    if (a % 10 == 4 && a != 14)
    {
        Console.WriteLine(" Four");
    }

    if (a % 10 == 5 && a != 15)
    {
        Console.WriteLine(" Five");
    }

    if (a % 10 == 6 && a != 16)
    {
        Console.WriteLine(" Six");
    }

    if (a % 10 == 7 && a != 17)
    {
        Console.WriteLine(" Seven");
    }

    if (a % 10 == 8 && a != 18)
    {
        Console.WriteLine(" Eight");
    }

    if (a % 10 == 9 && a != 19)
    {
        Console.WriteLine(" Nine");
    }

    if (a == 100)
    {
        Console.WriteLine("One Hundred");
    }
}
else
{
    Console.WriteLine("I told you from 0 to 100!");
}

Console.ReadLine();