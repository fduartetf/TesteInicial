using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exemplo1;

namespace Testes
{
    [TestClass]
    public class TesteCalculadora
    {
        [TestMethod]
        public void TesteSoma()
        {
            calculadora c = new calculadora();
            int result = c.Soma(3, 4);

            Assert.AreEqual(7, result);
        }
    }
}
