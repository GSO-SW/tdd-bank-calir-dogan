using Bank;

namespace Einzahlungstest
{
    [TestClass]
    public class Einzahlungtest
    {
        [TestMethod]
        public void nachn_einzahlung_betrag_prüfen()
        {
            int startKapital = 0;
            Konto einzahlungTest = new Konto(startKapital);

            int einzahlungGesamt = 100;
            int einzahlung = 50;
            einzahlungTest.Einzahlen(einzahlung);
            einzahlungTest.Einzahlen(einzahlung);

            Assert.AreEqual(einzahlungGesamt, einzahlungTest.Guthaben);
        }
    }
}
