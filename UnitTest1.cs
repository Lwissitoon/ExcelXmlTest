using System;

using NUnit.Framework;

namespace DataConvertion
{
    [TestFixture]
    public class UnitTest1
    {
        [SetUp]
        public void SetUp()
        {
            Data.exceltoxml();
        }

        [Test]
        public void TestMethod1(string nombre)
        {

            Assert.AreEqual(nombre,nombre);

        }
    }
}
