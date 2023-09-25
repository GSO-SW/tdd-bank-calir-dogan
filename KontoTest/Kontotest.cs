using Bank;
namespace KontoTest
{
    [TestClass]
    public class Kontotest
    {
        [TestMethod]
        public void konto_mit_guthaben_offnen()
        {
            int startKapital = 200;

            Konto kontoTest = new Konto(startKapital);

            Assert.AreEqual(200, kontoTest.Guthaben);
        }
    }
}