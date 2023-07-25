

public class Program
{
     static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter Number");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Multiplication Table of"+""+n);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n+"x{0} = {1}", i, n * i);
        }
    }
}