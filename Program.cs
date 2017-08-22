using System;

public class Program
{
    public static void Main()
    {
        bool first = true; string[] str = { "" }; Random numGen = new Random();
        while (true)
        {
            Console.Clear();
            Console.Write(first ? "List seperated with commas\n\n> " : str[numGen.Next(0, str.Length)]);
            if (first) str = Console.ReadLine().Split(',');
            else Console.ReadKey();
            first = !first;
        }
    }
}