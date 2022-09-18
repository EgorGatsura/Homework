using Homework2;

Console.WriteLine("What grade did you get?");
int a;
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Enter the grade you received");
}

if (a >= 0 && a <= 10)
{
    Grade result = Methods.Convert(a);
    Console.WriteLine(result.ToString());
}
else
{
    Console.WriteLine("There is no such assessment");
}

Console.ReadLine();