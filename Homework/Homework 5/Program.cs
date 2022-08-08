Console.WriteLine("Welcome to the calculator, enter the first number");
decimal a = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter the second number");
decimal b = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Choose what you want to do with them");
Console.WriteLine("[+] addition, [-] subtraction, [*] multiplication, [/] division");
var c = Console.ReadLine();
if (c is "+" or "-" or "*" or "/")
{
    switch (c)
    {
        case "+":
            Console.Write($"{a} + {b} = " + (a + b));
            break;
        case "-":
            Console.Write($"{a} - {b} = " + (a - b));
            break;
        case "*":
            Console.WriteLine($"{a} * {b} = " + (a * b));
            break;
        case "/":
            Console.WriteLine($"{a} / {b} = " + (a / b));
            break;
    }
}
else
{
    Console.WriteLine("Sorry, my program does not know how to do this");
}

Console.ReadLine();