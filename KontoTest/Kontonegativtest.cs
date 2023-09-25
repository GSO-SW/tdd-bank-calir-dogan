using Bank;
namespace Kontonegativtest
{

    [TestClass]
    public class Kontonegativtest
    {
        [TestMethod]
        public void kontostand_nicht_negativ()
        {
            int startKapital = -100;

            Konto kontonegativtest = new Konto(startKapital);

            Assert.AreEqual(-100, kontonegativtest.Guthaben);
     
        }
    }
}

