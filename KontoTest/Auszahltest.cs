using Bank;
namespace Auszahltest
{
    [TestClass]
    public class Auszahltest
    {
        [TestMethod]
        public void guthaben_stimmt_nach_auszahlung()
        {
            int startKapital = 200;

            Konto auszahlTest = new Konto(startKapital);

            int endWert = 50;
            int auszahlung = 150;

            auszahlTest.Auszahlen(auszahlung);

            Assert.AreEqual(endWert, auszahlTest.Guthaben);


        }
    }
}
