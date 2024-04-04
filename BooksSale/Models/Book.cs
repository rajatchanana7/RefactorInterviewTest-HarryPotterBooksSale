using BooksSale.CommonEnum;

namespace BooksSale.Models
{
    public partial class Book
    {
        public decimal BookPrice { get; } = 8m;
        public BooksNameEnum BooksName { get;}

        public Book(BooksNameEnum book)
        {
            BooksName = book;
        }

    }
}
