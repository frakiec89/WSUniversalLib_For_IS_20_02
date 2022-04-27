using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuantityForProductTest_114148()
        {
           int productType = 3;
           int materialType = 1;
           int count = 15;
           float width = 20f;
           float length = 45f;
           int expected = 114148;

           Calculation calculation = new Calculation(); 
           var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
           Assert.AreEqual(expected, actual);

        }
    }
}