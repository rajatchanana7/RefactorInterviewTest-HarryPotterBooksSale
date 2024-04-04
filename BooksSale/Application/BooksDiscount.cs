namespace BooksSale.Application
{
    internal class BooksDiscount
    {
        private readonly Dictionary<int, decimal> discount = new Dictionary<int, decimal>
        {
            {1, 0m },
            {2, 0.05m },
            {3, 0.1m },
            {4, 0.20m },
            {5, 0.25m }
        };

        public decimal GetBooksDiscount(int numberOfBooks)
        {
            return 1- discount[numberOfBooks];
        }
    }
}
