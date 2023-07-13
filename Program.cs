using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13julyA4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a Number");
            n= int.Parse(Console.ReadLine());
            if (n%2==0)
            {
                Console.WriteLine("The number is Even");
            }else { Console.WriteLine("The Number is odd"); }

            //Positive, Negative or Zero
            if (n < 0)
            {
                Console.WriteLine("The Number is Negative");
            }
            else if (n == 0)
            {
                Console.WriteLine("The Number is Zero");
            }
            else
            {
                Console.WriteLine("The Number is positive");
            }
            Console.ReadKey();
        }
    }
}
