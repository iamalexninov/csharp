using System.Runtime.InteropServices;

namespace SpecialNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new SpecialNumbers[]
            {
                new SpecialNumbers(7),
                new SpecialNumbers(15)
            };

            foreach (var item in outputs)
                item.PrintResult();
        }
    }

    public class SpecialNumbers
    {
        private int _n;

        public SpecialNumbers(int n)
        {
            this._n = n;
        }

        public void PrintResult()
        {
            for (int i = 1; i <= this._n; i++)
            {
                var sum = this.CalculeteDigitsSum(i);
                this.PrintCurrentNumberResultOnConsole(sum, i);
            }
        }

        private void PrintCurrentNumberResultOnConsole(int sum, int i)
        {
            string result = (sum == 5 || sum == 7 || sum == 11) ? "True" : "False";
            Console.WriteLine($"{i} -> {result}");
        }

        private int CalculeteDigitsSum(int i)
        {
            int firstDigit = i / 10;
            int secondDigit = i % 10;

            return firstDigit + secondDigit;
        }
    }
}

// sum of digits should be = 5,7,11
// variable n - read from 1 to n
// formulas
// i / 10 = take the first number
// i % 10 = take the second number