using System;

namespace UnitTestExample
{
    /// <summary>
    /// Example class against which one can run unit tests
    /// </summary>
    public static class ExampleClass
    {
        /// <summary>
        /// Adds together two integers
        /// </summary>
        /// <param name="int1">The first integer</param>
        /// <param name="int2">The second integer</param>
        /// <returns>The sum</returns>
        public static int AddIntegers(int int1, int int2)
        {
            return int1 + int2;
        }
        
        /// <summary>
        /// A qualitative assessment of a quantitative temperature measurement
        /// </summary>
        /// <param name="degreesF">The temperature in fahrenheit</param>
        /// <returns>What the temperature is like</returns>
        public static string GetTemperatureLevel(int degreesF)
        {
            if (degreesF <= 60)
                return "Cold";
            else if (degreesF >= 85)
                return "Hot";
            else
                return "Pleasant";
        }

        /// <summary>
        /// Determines whether or not the student passes the class
        /// </summary>
        /// <param name="grade">The student's grade</param>
        /// <param name="numAbsences">The number of absences the student had</param>
        /// <returns>Whether or not they passed</returns>
        public static bool DidStudentPassClass(double grade, int numAbsences)
        {
            return grade >= 60 && numAbsences < 3;
        }

        /// <summary>
        /// Postpends "[out of stock]" when item is out of stock
        /// </summary>
        /// <param name="name">The item name</param>
        /// <param name="quantity">The quantity in stock</param>
        /// <returns>The processed item name</returns>
        public static string ProcessItemName (string name, int quantity)
        {
            if (quantity == 0)
                name = name + " [out of stock]";
            return name;
        }
    }
}
