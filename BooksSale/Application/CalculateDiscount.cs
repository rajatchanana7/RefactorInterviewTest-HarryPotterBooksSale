using BooksSale.CommonEnum;
using BooksSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSale.Application
{
    /// <summary>
    /// This page will get maximum Discounted price.
    /// </summary>
    public class CalculateDiscount
    {
        private readonly List<BooksSet> bookSets = new List<BooksSet>();

        public decimal CalculatedPrice
        {
            get
            {
                return bookSets.Sum(x => x.Price);
            }
        }

       public void AddBook(Book book)
        {
            var availableBookSet = bookSets.Where(a => !a.BookExists(book));

            if (availableBookSet !=null && availableBookSet.Count()>0)
            {
                MaximumDiscountedBookSet(availableBookSet, book).AddBook(book);
            } else
            {
                var newBookSet = new BooksSet();
                newBookSet.AddBook(book);
                bookSets.Add(newBookSet);
            }
        }

        public void AddBooks(BooksNameEnum booksName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                AddBook(new Book(booksName));
            }
        }

        //public void AddBooks(List<Book> books)
        //{
        //    foreach (var book in books)
        //    {
        //        AddBook(book);
        //    }
        //}

        public string GetBookSets()
        {
            string? showBookSet = null;
            foreach (var item in bookSets)
            {
                showBookSet = showBookSet + item.GetBookSet() + Environment.NewLine;
            }

            return showBookSet;
        }


        private BooksSet MaximumDiscountedBookSet(IEnumerable<BooksSet> bookSets, Book book) {
            BooksSet? bestBookSet = null;
            decimal price = decimal.MaxValue;

            foreach (var bookSet in bookSets)
            {
                bookSet.AddBook(book);
                if (CalculatedPrice < price)
                {
                    price= CalculatedPrice;
                    bestBookSet= bookSet;
                }
                bookSet.RemoveBook(book);
            }

            return bestBookSet;
        
        }



    }
}
