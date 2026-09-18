using System.Runtime.InteropServices;

namespace FromLeftToRight
{
    public class Program
    {
        static void Main(string[] args)
        {
            FromLeftToRight[] output = new FromLeftToRight[2]
            {
                new FromLeftToRight(2),
                new FromLeftToRight(4),
            };

            foreach (var item in output)
                item.CalculateNumbersAndPrintResult();
        }
    }

    public class FromLeftToRight
    {
        private int _receivedNumbers;

        public FromLeftToRight(int numbers)
        {
            _receivedNumbers = numbers;
        }

        public void CalculateNumbersAndPrintResult()
        {
            for (int i = 0; i < this._receivedNumbers; i++)
            {
                string[] values = Console.ReadLine().Split(" ");
                long leftNumber = Convert.ToInt64(values[0]);
                long rightNumber = Convert.ToInt64(values[0]);

                long highestResult = leftNumber > rightNumber ? leftNumber : rightNumber;
                Console.WriteLine(
                highestResult.ToString()
                    .ToCharArray()
                    .Select(x => x - '0') // TODO: Understand it: the key here - Subtracting '0' converts a digit character into its numeric value. 
                    .ToArray()
                    .Sum()
                    );
            }
        }
    }
}