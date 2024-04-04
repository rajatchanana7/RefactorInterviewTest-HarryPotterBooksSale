using BooksSale.CommonEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSale.Application
{
    public static class BooksSalesInput
    {
        public static void UserInput()
        {
            Console.WriteLine("***************************************************************");
            CalculateDiscount calculateDiscount = new CalculateDiscount();

            foreach (BooksNameEnum booksQuantity in Enum.GetValues(typeof(BooksNameEnum)))
            {
                Console.Write($"Please enter number of books for {booksQuantity.ToString()} : ");
                string booksEntered = Console.ReadLine();

                if (int.TryParse(booksEntered, out int quantity))
                {
                    calculateDiscount.AddBooks(booksQuantity, quantity);
                } else
                {
                    Console.WriteLine("Invalid Input, please enter numeric value.");
                }
            }

            Console.WriteLine();
            Console.WriteLine($" The total price of Books set is : {calculateDiscount.CalculatedPrice}");
            Console.WriteLine("Number of books entered by User is : ");
            Console.WriteLine(calculateDiscount.GetBookSets());

        }
    }
}
