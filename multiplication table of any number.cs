using System;
public class Program
{
     static void Main(string[] args)
    {
        int valueOne;
        Console.WriteLine("Enter Number");
        valueOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Multiplication Table of"+""+valueOne);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(valueOne+" x "+i+" = "+(valueOne*i));
        }
    }
}

