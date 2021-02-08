using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Turn10TestQuestion;

namespace Mathml_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddValue_AddsValues_ReturnsInt()
        {
            var math = new Mathml();
            Assert.Equals(1, math.AddValue(math.GetValue("value1"), math.GetValue("value2")));
        }

        [TestMethod]
        public void Subtract_SubtractsValues_ReturnsInt()
        {
            var math = new Mathml();
            Assert.Equals(1, math.SubtractValue(math.GetValue("value1"), math.GetValue("value2")));
        }

        [TestMethod]
        public void Multiply_MultipliesValues_ReturnsInt()
        {
            var math = new Mathml();
            Assert.Equals(1, math.MultiplyValue(math.GetValue("value1"), math.GetValue("value2")));
        }

        [TestMethod]
        public void Divide_DividesValues_ReturnsInt()
        {
            var math = new Mathml();
            Assert.Equals(1.2D, math.DivideValue(math.GetValue("value1"), math.GetValue("value2")));
        }
    }
    }
