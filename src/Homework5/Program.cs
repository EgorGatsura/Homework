using Homework5;

Console.WriteLine("Welcome to the calculator, enter the first number");
decimal a = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter the second number");
decimal b = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Choose what you want to do with them");
Console.WriteLine("[+] addition, [-] subtraction, [*] multiplication, [/] division");
var c = Console.ReadLine();
if (c is "+")
{
    decimal result = Calculator.Addition(a, b);
    Console.WriteLine(result);
}

if (c is "-")
{
    decimal result = Calculator.Subtraction(a, b);
    Console.WriteLine(result);
}

if (c is "*")
{
    decimal result = Calculator.Multiplication(a, b);
    Console.WriteLine(result);
}

if (c is "/")
{
    decimal result = Calculator.Division(a, b);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Sorry, my program does not know how to do this");
}

Console.ReadLine();