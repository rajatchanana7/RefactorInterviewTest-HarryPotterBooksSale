using BooksSale.Application;
using BooksSale.CommonEnum;

namespace BooksSales.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Buy5Books()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();


            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 1);

            Assert.AreEqual(30m, calculateDiscount.CalculatedPrice);


        }

        [TestMethod]
        public void Buy7Books()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();


            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 3);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 0);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 2);

            Assert.AreEqual(59.20m, calculateDiscount.CalculatedPrice);


        }

        [TestMethod]
        public void Buy8Books()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();
            

            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 1);

            Assert.AreEqual(51.20m, calculateDiscount.CalculatedPrice);

           
        }
        [TestMethod]
        public void Buy8BooksP1()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();


            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 1);

            Assert.AreEqual(51.20m, calculateDiscount.CalculatedPrice);


        }

        [TestMethod]
        public void Buy8BooksP2()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();


            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 2);

            Assert.AreEqual(51.60m, calculateDiscount.CalculatedPrice);
        }

        [TestMethod]
        public void Buy8BooksP3()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();


            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 2);

            Assert.AreEqual(51.60m, calculateDiscount.CalculatedPrice);
        }

        [TestMethod]
        public void Buy8BooksP4()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();


            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 2);

            Assert.AreEqual(51.60m, calculateDiscount.CalculatedPrice);
        }

        [TestMethod]
        public void Buy8BooksP5()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();


            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 2);

            Assert.AreEqual(51.60m, calculateDiscount.CalculatedPrice);
        }

        [TestMethod]
        public void Buy9BooksP1()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();


            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 1);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 3);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 2);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 1);

            Assert.AreEqual(59.20m, calculateDiscount.CalculatedPrice);
        }

        [TestMethod]
        public void Buy23Books()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();


            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 5);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 5);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 4);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 5);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 4);

            Assert.AreEqual(141.20m, calculateDiscount.CalculatedPrice);
        }

        [TestMethod]
        public void Buy25Books()
        {
            CalculateDiscount calculateDiscount = new CalculateDiscount();


            calculateDiscount.AddBooks(BooksNameEnum.FirstBook, 5);
            calculateDiscount.AddBooks(BooksNameEnum.SecondBook, 5);
            calculateDiscount.AddBooks(BooksNameEnum.ThirdBook, 5);
            calculateDiscount.AddBooks(BooksNameEnum.FourthBook, 5);
            calculateDiscount.AddBooks(BooksNameEnum.FifthBook, 5);

            Assert.AreEqual(150m, calculateDiscount.CalculatedPrice);
        }
    }
}