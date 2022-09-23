namespace Homework4;

public static class Numbers
{
    public static string Numbersinwords(int a)
    {
        if (a == 0)
        {
            return "Zero";
        }

        if (a == 1)
        {
            return "One";
        }

        if (a == 2)
        {
            return "Two";
        }

        if (a == 3)
        {
            return "Three";
        }

        if (a == 4)
        {
            return "Four";
        }

        if (a == 5)
        {
            return "Five";
        }

        if (a == 6)
        {
            return "Six";
        }

        if (a == 7)
        {
            return "Seven";
        }

        if (a == 8)
        {
            return "Eight";
        }

        if (a == 9)
        {
            return "Nine";
        }

        if (a == 10)
        {
            return "Ten";
        }

        if (a == 11)
        {
            return "Eleven";
        }

        if (a == 12)
        {
            return "Twelve";
        }

        if (a is >= 13 and <= 19)
        {
            switch (a)
            {
                case 13:
                    return "Thirteen";
                case 14:
                    return "Fourteen";
                case 15:
                    return "Fifteen";
                case 16:
                    return "Sixteen";
                case 17:
                    return "Seventeen";
                case 18:
                    return "Eighteen";
                case 19:
                    return "Nineteen";
            }
        }

        switch (a / 10)
        {
            case 20:
                return"Twenty";
            case 30:
                return "Thirty";
            case 40:
                return "Forty";
            case 50:
                return "Fifty";
            case 60:
                return "Sixty";
            case 70:
                return "Seventy";
            case 80:
                return "Eighty";
            case 90:
                return "Ninety";
        }

        switch (a % 10)
        {
            case 1:
                return " One";
            case 2:
                return " Two";
            case 3:
                return " Three";
            case 4:
                return " Four";
            case 5:
                return " Five";
            case 6:
                return " Six";
            case 7:
                return " Seven";
            case 8:
                return " Eight";
            case 9:
                return " Nine";
        }

        if (a == 100)
        {
            return "One Hundred";
        }
        return "";
    }
    
}