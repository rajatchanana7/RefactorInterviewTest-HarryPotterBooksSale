using BooksSale.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSale
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Books Sale Program.");

            do
            {
                BooksSalesInput.UserInput();
                Console.Write("Please enter 'q' key to quit, or any key to continue for another round : ");


            } while (!"q".Equals(Console.ReadLine(), StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
