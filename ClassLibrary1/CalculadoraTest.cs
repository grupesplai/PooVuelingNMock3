using System;
using NMock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVuelingNMock3;

namespace ClassLibrary1
{
    [TestClass]
    public class CalculadoraTests
    {
        private MockFactory mock;
        private Mock<ICalculadora> viewMock;
        

        [TestInitialize]
        public void Setup()
        {
            mock = new MockFactory();
            viewMock = mock.CreateMock<ICalculadora>();
            viewMock.Expects.One.MethodWith(x => x.Suma(2, 2)).WillReturn(4);
            viewMock.Expects.One.MethodWith(x => x.Resta(4, 2)).WillReturn(2);
            viewMock.Expects.One.MethodWith(x => x.Division(4, 2)).WillReturn(2);
            viewMock.Expects.One.MethodWith(x => x.Multiplicacion(4, 2)).WillReturn(8);
        }

        [TestMethod]
        public void DivisionTest()
        {
            var result = viewMock.MockObject.Division(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MultiplicacionTest()
        {
            var result = viewMock.MockObject.Multiplicacion(4, 2);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void RestaTest()
        {
            var result = viewMock.MockObject.Resta(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SumaTest()
        {
            var result = viewMock.MockObject.Suma(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}

