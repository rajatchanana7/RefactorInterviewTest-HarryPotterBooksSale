using BooksSale.CommonEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSale.Models
{
    public partial class Book
    {
        public decimal BookPrice { get; } = 8m;
        public BooksNameEnum BooksQuantity { get;}

        public Book(BooksNameEnum booksQuantity)
        {
            BooksQuantity = booksQuantity;
        }

    }
}
