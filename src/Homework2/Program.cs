using Homework2;

Console.WriteLine("What grade did you get?");
int a;
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Enter the grade you received");
}

Grade result = Methods.Convert(a);
Console.WriteLine(result.ToString());
Console.ReadLine();