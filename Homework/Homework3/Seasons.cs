namespace Homework3;

public class Seasons
{
    static void SeasonMethod (int a)
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
}