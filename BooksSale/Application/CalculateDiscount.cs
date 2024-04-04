using BooksSale.CommonEnum;
using BooksSale.Models;

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
                MaximumDiscountedBookSet(availableBookSet, book).AddBookInBookSet(book);
            } else
            {
                var newBookSet = new BooksSet();
                newBookSet.AddBookInBookSet(book);
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


        private BooksSet MaximumDiscountedBookSet(IEnumerable<BooksSet> bookSets, Book book) {
            BooksSet? bestBookSet = null;
            decimal price = decimal.MaxValue;

            foreach (var bookSet in bookSets)
            {
                bookSet.AddBookInBookSet(book);
                if (CalculatedPrice < price)
                {
                    price= CalculatedPrice;
                    bestBookSet= bookSet;
                }
                bookSet.RemoveBookFromBookSet(book);
            }
            return bestBookSet;
        }
    }
}
