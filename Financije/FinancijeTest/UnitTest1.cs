using System;
using Financije;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinancijeTest
{
    [TestClass]
    public class Bank
    {
        [TestMethod]
        public void Test1()
        {
            Banka banka = new Banka();
            Assert.IsNull(banka.DohvatiRacun("HR12"));
        }
        [TestMethod]
        public void Test2()
        {
            Banka banka = new Banka();
            Racun racun=banka.DohvatiRacun("HR11");
            
            Assert.AreEqual(racun.IBAN,"HR11");
        }
        [TestMethod]
        public void Test3()
        {
            Banka banka = new Banka();
            Racun racun = banka.DohvatiRacun("HR44");
            Assert.IsTrue(racun.IBAN=="HR44");
        }
        [TestMethod]
        public void Test4()
        {
            Banka banka = new Banka();
            Racun racun = banka.DohvatiRacun("HR11");
            Racun primatelj = banka.DohvatiRacun("HR21");
            racun.Isplati(primatelj,30000);
            Assert.IsTrue(racun.Stanje == -20000);
        }
        [TestMethod]
        public void Test5()
        {
            Banka banka = new Banka();
            Racun racun = banka.DohvatiRacun("HR11");
            Racun primatelj = banka.DohvatiRacun("HR22");
            racun.Isplati(primatelj, 30000);
            Assert.IsTrue(racun.Stanje == 70000 && primatelj.Stanje==80000);
        }
    }
}
