using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main()
        {
          string firstName;
          string lastName;

          Console.WriteLine("enter first name");
          firstName=Console.ReadLine();

          Console.WriteLine("enter last name");
          lastName=Console.ReadLine();

          Console.WriteLine("full Name is "+ firstName+" "+lastName);


        }
    }
}