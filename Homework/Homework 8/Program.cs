Console.WriteLine("Enter the size of the array");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(99);
    Console.Write(array[i] + " ");
}

Console.WriteLine("Let's take the prime numbers");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 2)
    {
        if (array[i] == 2 | array[i] == 3 | array[i] == 5 | array[i] == 7)
        {
            Console.Write(array[i] + " ");
            return;
        }

        if (array[i] % 2 == 0 | array[i] % 3 == 0 | array[i] % 5 == 0 | array[i] % 7 == 0)
        {
            Console.Write("");
        }
        else
        {
            Console.Write(array[i] + " ");
        }
    }
    else
    {
        Console.Write("");
    }
}

Console.ReadLine();