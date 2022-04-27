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

        [TestMethod()]
        public void GetQuantityForProductTest_1_minus1()
        {
            int productType = 30;
            int materialType = 1;
            int count = 15;
            float width = 20f;
            float length = 45f;
            int expected = -1;

            Calculation calculation = new Calculation();
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_2_minus1()
        {
            int productType = 1;
            int materialType = 15;
            int count = 15;
            float width = 20f;
            float length = 45f;
            int expected = -1;

            Calculation calculation = new Calculation();
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void GetQuantityForProductTest_3_minus1()
        {
            int productType = 15;
            int materialType = 15;
            int count = 15;
            float width = 20f;
            float length = 45f;
            int expected = -1;

            Calculation calculation = new Calculation();
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetQuantityForProductTest_4_minus1()
        {
            int productType = 1;
            int materialType = 1;
            int count = -5;
            float width = 20f;
            float length = 45f;
            int expected = -1;

            Calculation calculation = new Calculation();
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_5_minus1()
        {
            int productType = 1;
            int materialType = 1;
            int count = 5;
            float width = -5f;
            float length = 45f;
            int expected = -1;

            Calculation calculation = new Calculation();
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void GetQuantityForProductTest_6_minus1()
        {
            int productType = 15;
            int materialType = 1;
            int count = 5;
            float width = -5f;
            float length = 45f;
            int expected = -1;

            Calculation calculation = new Calculation();
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void GetQuantityForProductTest_7_minus1()
        {
            int productType = 15;
            int materialType = 15;
            int count = 0;
            float width = -5f;
            float length = 45f;
            int expected = -1;

            Calculation calculation = new Calculation();
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }
    }
}