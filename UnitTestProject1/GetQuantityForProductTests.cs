using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class GetQuantityForProductTests
    {
        [TestMethod]
        public void ReturnCorrectValue()
        {
            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            Calculation calculation = new Calculation();
            int expected = 114148;

            int actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductTypeEqualsZero()
        {
            int productType = 0;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            Calculation calculation = new Calculation();
            int expected = -1;

            int actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NonExistentProductType()
        {
            int productType = 20;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            Calculation calculation = new Calculation();
            int expected = -1;

            int actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NonExistentMaterialType()
        {
            int productType = 20;
            int materialType = 0;
            int count = 15;
            float width = 20;
            float length = 45;

            Calculation calculation = new Calculation();
            int expected = -1;

            int actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CountEqualZero()
        {
            int productType = 20;
            int materialType = 1;
            int count = 0;
            float width = 20;
            float length = 45;

            Calculation calculation = new Calculation();

            int expected = -1;

            int actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ImpossibleWidth()
        {
            int productType = 20;
            int materialType = 1;
            int count = 15;
            float width = -20;
            float length = 45;

            Calculation calculation = new Calculation();
            int expected = -1;

            int actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ImpossibleLength()
        {
            int productType = 20;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = -12;

            Calculation calculation = new Calculation();
            int expected = -1;

            int actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class SquareCalculationTests
    {
        [TestMethod]
        public void ReturnCorrectValue()
        {
            float width = 3f;
            float length = 4f;

            Calculation calculation = new Calculation();

            float expected = width * length;
            float actual = calculation.SquareCalculation(width, length);

            Assert.AreEqual(expected, actual);
        }

    }


    [TestClass]
    public class QualityRawMaterialsCalculationTests
    {
        [TestMethod]
        public void ReturnCorrectValue()
        {
            Calculation calculation = new Calculation();

            float square = 15f;
            float coefficient = 1.1f;
            int count = 3;

            float expected = square * count * coefficient;

            float actual = calculation.QualityRawMaterialsCalculation(square, coefficient, count);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ImpossibleSquare()
        {
            Calculation calculation = new Calculation();

            float square = -1;
            float coefficient = 1.1f;
            int count = 3;

            float expected = -1;

            float actual = calculation.QualityRawMaterialsCalculation(square, coefficient, count);
            Assert.AreEqual(expected, actual);
        }

    }

}
