using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorUnitedTesting;

namespace UnitTestProjectMegetVigtig
{
    [TestClass]
    public class UnitTestDivider
    {
        [TestMethod]
        public void TestDivider()
        {
            //Hvad er de tre A for noget?

            // arrange - Det Betyder man opsætter betingelserne for testen
            ClassCalc classCalc = new ClassCalc();
            double divRes = 3.666666667;

            // Act - Her udføre man handlingen, altså man kalder metoden der skal testes
            classCalc.BeregnAlt(22, 6);
            double divTest = classCalc.resDiv;

            // Assert - her undersøger man om metoden giver det forventede resultat
            Assert.AreEqual(divRes, divTest, 0.0001);
        }

        [TestMethod]
        public void TestGange()
        {
            //Hvad er de tre A for noget?

            // arrange - Det Betyder man opsætter betingelserne for testen
            ClassCalc classCalc = new ClassCalc();
            int gangeRes = 132;

            // Act - Her udføre man handlingen, altså man kalder metoden der skal testes
            classCalc.BeregnAlt(22, 6);
            int gangeTest = classCalc.resGange;

            // Assert - her undersøger man om metoden giver det forventede resultat
            Assert.AreEqual(gangeRes, gangeTest);
        }
    }
}
