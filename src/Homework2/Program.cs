using Homework2;

Console.WriteLine("What grade did you get?");
int a = Convert.ToInt32(Console.ReadLine());
Grade result = Methods.Convert(a);
Console.WriteLine(result.ToString());
Console.ReadLine();