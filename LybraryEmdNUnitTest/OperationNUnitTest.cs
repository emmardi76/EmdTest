using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEmd
{
    [TestFixture]

    public class OperationNUnitTest
    {
        [Test]

        public void AddNumbers_InputTwoNumbers_GetCorrectValue()
        {
            //1.Arrange
            //Initialize the variables or components that execute the test

            Operation op = new();
            int number1Test = 50;
            int number2Test = 69;

            //2.Act
            //Execute de Operation

            int result = op.AddNumbers(number1Test, number2Test);

            //3.Assert
            //Compare the result. Unittest Library

            Assert.AreEqual(119, result);

        }

        [Test]
        [TestCase(9, ExpectedResult = false)]
        [TestCase(5, ExpectedResult = false)]
        [TestCase(7, ExpectedResult = false)]

        public bool IsParValue_inputOddNumber_ReturnFalse(int oddNumber)
        {
            Operation op = new();            

            return op.IsParValue(oddNumber);           
        }

        [Test]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(20)]

        public void IsParValue_inputParNumber_ReturnTrue(int parNumber)
        {
            Operation op = new();           

            bool resultIsPar = op.IsParValue(parNumber);

            Assert.IsTrue(resultIsPar); //classic mode
            Assert.That(resultIsPar, Is.EqualTo(true)); //Other method to compare a bool type// restriction mode
        }

        [Test]
        [TestCase(2.2, 1.2)] //result must be 3.4
        [TestCase(2.23, 1.24)]   // result miust be 3.47    
        public void AddDecimalNumbers_InputTwoNumbers_GetCorrectValue(double decimal1Test, double decima21Test)
        {
            //1.Arrange
            //Initialize the variables or components that execute the test

            Operation op = new();           

            //2.Act
            //Execute de Operation

            double result = op.AddDecimalNumbers(decimal1Test, decima21Test);

            //3.Assert
            //Compare the result. Unittest Library

            // interval 3.3    3.5 , the result is an approximation
            Assert.AreEqual(3.4, result, 0.1); //delta value need sum/rest to fisrt value and the result two operation must be in the interval range 

        }

        [Test]

        public void GetListOddNumbers_InputMinimumMaximumIntervals_ReturnsListOddNumbers()
        {
            Operation op = new();

            List<int> expectedOddNumbers = new() {  5, 7 ,9};

            List<int> results = op.GetListOddNumbers(5,10);

            Assert.That(results, Is.EquivalentTo(expectedOddNumbers));
        }
    }
}