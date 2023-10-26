using System.Dynamic;

namespace LibraryEmd
{
    public class Operation
    {
        public List<int> OddNumbers = new();

        public int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public bool IsParValue(int number)
        { 
            return number % 2 == 0;
        } 

        public double AddDecimalNumbers(double decimal1, double decimal2)
        {
            return decimal1 + decimal2;
        }

        public List<int> GetListOddNumbers(int minimumInterval, int maximumInterval)
        {
            OddNumbers.Clear();

            for (int i = minimumInterval; i <= maximumInterval; i++)
            {
                if (i % 2 != 0)
                { 
                    OddNumbers.Add(i);
                }                
            }

            return OddNumbers;
        }
    }
}