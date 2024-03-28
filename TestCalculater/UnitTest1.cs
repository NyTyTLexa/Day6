using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace TestCalculater
{
    [TestClass]
    public class CalculaterTest
    {
        [TestMethod]
        public void NotExistProductType()
        {
            int productType = 4;
            int materialType = 1;
            int count = 5;
            float width = 200;
            float length = 140;

            Calculation calculation = new Calculation();
            int quantity = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, quantity);
        }

        [TestMethod]
        public void NotExistMaterialType()
        {
            int productType = 1;
            int materialType = 4;
            int count = 2;
            float width = 150;
            float length = 125;

            Calculation calculation = new Calculation();
            int quantity = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, quantity);
        }

        [TestMethod]
        public void NotSetQuantity()
        {
            int productType = 1;
            int materialType = 1;
            int count = 0;
            float width = 125;
            float length = 150;

            Calculation calculation = new Calculation();
            int quantity = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, quantity);
        }

        [TestMethod]
        public void NotSetWidth()
        {
            int productType = 1;
            int materialType = 1;
            int count = 1;
            float width = 0;
            float length = 150;

            Calculation calculation = new Calculation();
            int quantity = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, quantity);
        }

        [TestMethod]
        public void NotSetLength()
        {
            int productType = 1;
            int materialType = 1;
            int count = 5;
            float width = 150;
            float length = 0;

            Calculation calculation = new Calculation();
            int quantity = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, quantity);
        }
        [TestMethod]
        public void GetQuantityForProduct_ValidInputs_ReturnsExpectedQuantity()
        {
            // Arrange
            Calculation calculator = new Calculation();

            // Act
            int result = calculator.GetQuantityForProduct(1, 1, 2, 3.5f, 4.5f);

            // Assert
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_InvalidInputs_ReturnsMinusOne()
        {
            // Arrange
            Calculation calculator = new Calculation();

            // Act
            int result = calculator.GetQuantityForProduct(4, 1, 2, 3.0f, 4.0f);

            // Assert
            Assert.AreEqual(-1, result);
        }
        [TestMethod]
        public void GetQuantityForProduct_InvalidProductId_ReturnsMinusOne()
        {
            // Arrange
            Calculation calculator = new Calculation();

            // Act
            int result = calculator.GetQuantityForProduct(-1, 1, 2, 3.0f, 4.0f);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_ZeroPrice_ReturnsZero()
        {
            // Arrange
            Calculation calculator = new Calculation();

            // Act
            int result = calculator.GetQuantityForProduct(1, 1, 2, 0.0f, 4.0f);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativePrice_ReturnsMinusOne()
        {
            // Arrange
            Calculation calculator = new Calculation();

            // Act
            int result = calculator.GetQuantityForProduct(1, 1, 2, -3.0f, 4.0f);

            // Assert
            Assert.AreEqual(-1, result);
        }
    }
}