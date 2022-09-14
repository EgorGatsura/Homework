namespace Homework2;

public enum Grade
{
    WasAbsent = 1,
    NotSatisfactorily = 2,
    Satisfactorily = 3,
    Good = 4,
    Excellent = 5
}
    
public class Methods
{
    public static Grade Convert(int a)
    {
        if (a < 0 || a > 10)
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }

        if (a <= 2)
        {
            return Grade.WasAbsent;
        }

        if (a <= 4)
        {
            return Grade.NotSatisfactorily;
        }

        if (a <= 6)
        {
            return Grade.Satisfactorily;
        }

        if (a <= 8)
        {
            return Grade.Good;
        }

        return Grade.Excellent;
    }
}