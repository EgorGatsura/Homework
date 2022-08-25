using Homework1;

Console.WriteLine("Enter the length of the first side of the triangle");
int a;
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Enter the length");
}

Console.WriteLine("Enter the length of the second side of the triangle");
int b;
while (!int.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Enter the length");
}

Console.WriteLine("Enter the length of the third side of the triangle");
int c;
while (!int.TryParse(Console.ReadLine(), out c))
    Console.WriteLine("Enter the length");

Console.WriteLine($"Length of the first side {a}  Length of the second side {b}  Length of the third side {c}");
Homework.IsTriangle(a, b, c);
// bool d = 
Console.ReadLine();