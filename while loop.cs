using System;
public class Program
{
     static void Main(string[] args)
    {
        int valueOne;
        int valueTwo=1;
        
        Console.WriteLine("Enter Number");
        valueOne = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Multiplication Table of"+" "+valueOne);
        while(valueTwo <= 20)
        {
            Console.WriteLine(valueOne+" x " +valueTwo+ " = "+(valueOne*valueTwo));
            valueTwo++;
        }
    }
}
