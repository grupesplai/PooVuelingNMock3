using System;
using NMock;
using PooVuelingNMock3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PooVuelingNMock3.Integration.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        private MockFactory mock;
        private Mock<ICalculadora> viewMock;


        [TestInitialize]
        public void Setup()
        {
            mock = new MockFactory();
            viewMock = mock.CreateMock<ICalculadora>();
            viewMock.Expects.One.GetProperty(x => x.Suma(2, 2)).WillReturn(4);
            viewMock.Expects.One.GetProperty(x => x.Resta(4, 2)).WillReturn(2);
            viewMock.Expects.One.GetProperty(x => x.Division(4, 2)).WillReturn(2);
            viewMock.Expects.One.GetProperty(x => x.Multiplicacion(4, 2)).WillReturn(8);
        }

        [TestMethod]
        public void b()
        {
        }
    }
}