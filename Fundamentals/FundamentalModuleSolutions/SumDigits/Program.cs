namespace SumDigits
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new SumDigits[3]
            {
                new SumDigits(245678),
                new SumDigits(97561),
                new SumDigits(543),
            };

            foreach (var item in outputs)
                item.PrintFinalResultOnTheConsole();
        }
    }

    public class SumDigits
    {
        private int _number;
        private int _sumOfDigits;

        public SumDigits(int number) => this._number = number;

        private int CalculateSumOfDigits(int number, int sum)
        {
            char[] arr = number.ToString().ToCharArray();

            foreach (var item in arr)
                sum += int.Parse(item.ToString());

            return sum;
        }

        public void PrintFinalResultOnTheConsole()
        {
            var finalSum = this.CalculateSumOfDigits(this._number, this._sumOfDigits);
            Console.WriteLine(finalSum);
        }
    }
}
