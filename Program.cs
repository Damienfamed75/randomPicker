using System;

public class Program
{
    static void Main()
    {
        int i = 1;
        while(i==1)
        {
            Console.Clear();
            Console.Write("List seperated with commas\n\n> ");
            var str = Console.ReadLine().Split(',');
            Random numGen = new Random();
            Console.Clear();
            Console.Write(str[numGen.Next(0, str.Length)]);
            Console.ReadKey();
        }
    }
}