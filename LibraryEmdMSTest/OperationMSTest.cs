using LibraryEmd;

namespace LibraryEmdMSTest
{
    [TestClass]
    public class OperationMSTest
    {
        [TestMethod]

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
    }
}
