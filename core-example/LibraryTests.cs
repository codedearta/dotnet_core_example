using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary.Test
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        // private readonly PrimeService _primeService;
        //  public PrimeService_IsPrimeShould()
        //  {
        //      _primeService = new PrimeService();
        //  }

        [TestMethod]
        public void APassingTest()
        {
            //var result = _primeService.IsPrime(1);


            Assert.IsFalse(false);
            //Assert.IsFalse(false, "1 should not be prime");
        }

        [TestMethod]
        public void AFailingTest()
        {
            //var result = _primeService.IsPrime(1);


            Assert.IsFalse(true);
            //Assert.IsFalse(false, "1 should not be prime");
        }
    }
}