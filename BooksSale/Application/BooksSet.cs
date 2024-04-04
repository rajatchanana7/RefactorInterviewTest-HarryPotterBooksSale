using BooksSale.CommonEnum;
using BooksSale.Models;

namespace BooksSale.Application
{
    internal class BooksSet
    {
        private readonly List<Book> books= new List<Book>();
        private readonly BooksDiscount discount= new BooksDiscount();

        public decimal Price
        {
            get
            {
                decimal booksDiscount = discount.GetBooksDiscount(books.Count);
                return books.Sum(a=> a.BookPrice)* booksDiscount;
            }
        }

        public bool BookExists(Book book)
        {
            return books.Exists(a=> a.BooksQuantity == book.BooksQuantity);
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book) { 
        
            books.Remove(book);
        }

        public string GetBookSet()
        {
            string? bookSet = null;
            foreach (BooksNameEnum booksName in  Enum.GetValues(typeof(BooksNameEnum)))
            {
                string bookExists= books.Exists(a=> a.BooksQuantity== booksName) ?"1":"0";
                bookSet = bookSet == null ? bookExists : $"{bookSet}, {bookExists}";
            }

            return bookSet;
        }

    }
}
