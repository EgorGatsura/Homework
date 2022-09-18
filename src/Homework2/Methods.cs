namespace Homework2;

public enum Grade
{
    WasAbsent = 1,
    NotSatisfactorily = 2,
    Satisfactorily = 3,
    Good = 4,
    Excellent = 5,
}

public class Methods
{
    public static Grade Convert(int a)
    {
        switch (a)
        {
            case < 0:
            case > 10:
                throw new ArgumentOutOfRangeException(nameof(a));
            case <= 2:
                return Grade.WasAbsent;
            case <= 4:
                return Grade.NotSatisfactorily;
            case <= 6:
                return Grade.Satisfactorily;
            case <= 8:
                return Grade.Good;
            default:
                return Grade.Excellent;
        }
    }
}