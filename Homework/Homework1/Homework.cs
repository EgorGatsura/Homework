namespace Homework1;

public class Homework
{
    public static bool IsTriangle(int a, int b, int c)
    {
        return a + b >= c && a + c >= b && c + b >= a && a != 0 && b != 0 && c != 0;
    }
}