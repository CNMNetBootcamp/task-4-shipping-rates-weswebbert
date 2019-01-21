using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            string cost = string.Empty;
            double pounds = 0.0;

            Console.WriteLine("How many pounds is the package?");
            pounds = Double.Parse(Console.ReadLine());

            if (pounds <= 2) 
            {
                cost = "$2";
            }
            else if (pounds > 2 && pounds <= 6)
            {
                cost = "$4";
            }
            else if (pounds > 6 && pounds <= 10)
            {
                cost = "$6";
            }
            else if (pounds > 10)
            {
                cost = "$10";
            }
            else
            {
                cost = "$10";
            }
            Console.WriteLine("The cost of shipping is " + cost);
            Console.ReadLine();

        }
    }
}

