using BooksSale.Models;

namespace BooksSale.IApplication
{
    public interface IBookSet
    {
        bool BookExists(Book book);
        void AddBookInBookSet(Book book);
        void RemoveBookFromBookSet(Book book);
    }
}
