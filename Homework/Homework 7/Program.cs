﻿int[] array = new int[15];
Console.WriteLine(array);
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(999);
    Console.Write(array[i] + " ");
}

Array.Reverse(array);
Console.WriteLine("Flip the array");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.ReadLine();