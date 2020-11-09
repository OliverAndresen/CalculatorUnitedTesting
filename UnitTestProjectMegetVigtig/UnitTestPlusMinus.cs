using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorUnitedTesting;

namespace UnitTestProjectMegetVigtig
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTestPlusMinus
    {
        public UnitTestPlusMinus()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestPlus()
        {
            //Hvad er de tre A for noget?

            // arrange - Det Betyder man opsætter betingelserne for testen
            ClassCalc classCalc = new ClassCalc();
            int plusRes = 28;

            // Act - Her udføre man handlingen, altså man kalder metoden der skal testes
            classCalc.BeregnAlt(22, 6);
            int plusTest = classCalc.resPlus;

            // Assert - her undersøger man om metoden giver det forventede resultat
            Assert.AreEqual(plusRes, plusTest);
        }
        [TestMethod]
        public void Testminus()
        {
            //Hvad er de tre A for noget?

            // arrange - Det Betyder man opsætter betingelserne for testen
            ClassCalc classCalc = new ClassCalc();
            int minusRes = 16;

            // Act - Her udføre man handlingen, altså man kalder metoden der skal testes
            classCalc.BeregnAlt(22, 6);
            int minusTest = classCalc.resMinus;

            // Assert - her undersøger man om metoden giver det forventede resultat
            Assert.AreEqual(minusRes, minusTest);
        }
    }
}
