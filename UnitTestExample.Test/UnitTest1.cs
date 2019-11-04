using NUnit.Framework;
using UnitTestExample;

namespace Tests
{
    /// <summary>
    /// Unit tests example
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Runs one time before all the tests
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            // Code to run one time before all the tests
        }

        /// <summary>
        /// Runs one time after all tests have been run
        /// </summary>
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // Code to run one time after all tests have been run
        }

        /// <summary>
        /// Tests that 5 and 2 makes 7
        /// </summary>
        [Test]
        public void AddIntegers_5_2_Returns_7()
        {
            // 1) Arrange
            int value1 = 5;
            int value2 = 2;
            int expected = 7;

            // 2) Act
            int actual = ExampleClass.AddIntegers(value1, value2);

            // 3) Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests the "Hot" condition of GetTemperatureLevel
        /// </summary>
        [Test]
        public void GetTemperatureLevel_100_Returns_Hot()
        {
            // 1) Arrange
            int temperature = 100;
            string expected = "Hot";

            // 2) Act
            string actual = ExampleClass.GetTemperatureLevel(temperature);

            // 3) Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests the "Pleasant" condition of GetTemperatureLevel
        /// </summary>
        [Test]
        public void GetTemperatureLevel_72_Returns_Pleasant()
        {
            // 1) Arrange
            int temperature = 72;
            string expected = "Pleasant";

            // 2) Act
            string actual = ExampleClass.GetTemperatureLevel(temperature);

            // 3) Assert
            Assert.AreEqual(expected, actual);
        }
        
        /// <summary>
        /// Tests if a student passed if they had a grade of 80 and 2 absences
        /// </summary>
        [Test]
        public void DidStudentPassClass_80_Grade_2_Absences_Returns_True()
        {
            // 1) Arrange
            int grade = 80;
            int numAbsences = 2;

            // 2) Act
            bool actual = ExampleClass.DidStudentPassClass(grade, numAbsences);

            // 3) Assert
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Makes sure function doesn't postpend "[out of stock]" when not out of stock
        /// </summary>
        [Test]
        public void ProcessItemName_6_Quantity_Does_Not_Return_OutOfStock()
        {
            // 1) Arrange
            string itemName = "Widget";
            int quantity = 6;

            // 2) Act
            string actual = ExampleClass.ProcessItemName(itemName, quantity);

            // 3) Assert
            Assert.AreEqual(itemName, actual);
        }

        /// <summary>
        /// Makes sure function postpends "[out of stock]" when out of stock
        /// </summary>
        [Test]
        public void ProcessItemName_0_Quantity_Returns_OutOfStock()
        {
            // 1) Arrange
            string itemName = "Widget";
            int quantity = 0;
            string expected = itemName + " [out of stock]";

            // 2) Act
            string actual = ExampleClass.ProcessItemName(itemName, quantity);

            // 3) Assert
            Assert.AreEqual(expected, actual);
        }
    }
}