using Microsoft.VisualStudio.TestTools.UnitTesting;
using SVLT.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVLT.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        [TestMethod()]
        public void CelsiusToFarenheitTest()
        {
            TemperatureConverter converter = new TemperatureConverter();

            double result = converter.CelsiusToFarenheit(31.0);

            Assert.AreEqual(87.8, result);
        }

        [TestMethod()]
        public void FarenheitToCelsiusTest()
        {
            TemperatureConverter converter = new TemperatureConverter();

            double result = converter.FarenheitToCelsius(100.0);
            double tolerancia = 0.01;

            Assert.AreEqual(37.778, result, tolerancia);
        }
    }
}