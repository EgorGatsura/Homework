namespace Homework3;

public enum EnumSeason
{
    Winter = 1,
    Spring = 2,
    Summer = 3,
    Autumn = 4,
}

public static class Seasons
{
    public static EnumSeason MethodSeason(int a)
    {
        if (a < 0 || a > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }

        if (a == 1 || a == 2 || a == 12)
        {
            return EnumSeason.Winter;
        }

        if (a == 3 || a == 4 || a == 5)
        {
            return EnumSeason.Spring;
        }

        if (a == 6 || a == 7 || a == 8)
        {
            return EnumSeason.Summer;
        }
        return EnumSeason.Autumn;
    }
}