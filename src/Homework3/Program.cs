using Homework3;

Console.WriteLine("Choose the name of the month");
Console.WriteLine(
    "1 [January] 2 [February] 3 [March] 4 [April] 5 [May] 6 [June] 7 [July] 8 [August] 9 [September] 10 [October] 11 [November] 12 [December]");
int a;
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Choose an option according to the suggested");
}

if (a >= 1 && a <= 12)
{
    EnumSeason result = Seasons.MethodSeason(a);
    Console.WriteLine(result.ToString());
}
else
{
    Console.WriteLine("I see you are a joker....");
}

Console.ReadLine();