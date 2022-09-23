using Homework4;

Console.WriteLine("Enter a number from 0 to 100");
int a;
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("You need to enter a number from 0 to 100");
}
if (a <= 100)
{
    string result = Numbers.Numbersinwords(a);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("I told you from 0 to 100!");
}

Console.ReadLine();
System.Diagnostics.Process.GetCurrentProcess().Kill(); 