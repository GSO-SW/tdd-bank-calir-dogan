using Bank;

namespace AuszahlgesamtTest
{
    [TestClass]
    public class AuszahlgesamtTest
    {
        [TestMethod]
        public void guthaben_stimmt_nach_gesamtauszahlung()
        {
            int startKapital = 200;

            Konto auszahlGesamtTest = new Konto(startKapital);

            auszahlGesamtTest.Auszahlen(startKapital);

            Assert.AreEqual(0, auszahlGesamtTest.Guthaben);
        }
    }
}
