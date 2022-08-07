Console.WriteLine("Welcome to the calculator, enter the first number");
decimal a = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter the second number");
decimal b = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Choose what you want to do with them");
Console.WriteLine("[+] addition, [-] subtraction, [*] multiplication, [/] division");
string c = Console.ReadLine();
if (c == "+" || c == "-" || c == "*" || c == "/")
{
    switch (c)
    {
        case "+":
            Console.Write("Final result ");
            Console.Write($"{a} + {b} = ");
            Console.Write(a + b);
            break;
        case "-":
            Console.Write("Final result ");
            Console.Write($"{a} - {b} = ");
            Console.Write(a - b);
            break;
        case "*":
            Console.WriteLine("Final result ");
            Console.Write($"{a} * {b} = ");
            Console.Write(a * b);
            break;
        case "/":
            Console.WriteLine("Final result ");
            Console.Write($"{a} / {b} = ");
            Console.Write(a / b);
            break;
    }
}
else
{
    Console.WriteLine("Sorry, my program does not know how to do this");
}

Console.ReadLine();