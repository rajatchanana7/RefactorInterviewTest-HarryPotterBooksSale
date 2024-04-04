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
            return books.Exists(a=> a.BooksName == book.BooksName);
        }

        public void AddBookInBookSet(Book book)
        {
            books.Add(book);
        }

        public void RemoveBookFromBookSet(Book book) { 
        
            books.Remove(book);
        }

    }
}
