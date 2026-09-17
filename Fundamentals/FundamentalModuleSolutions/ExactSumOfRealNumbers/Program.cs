namespace ExactSumOfRealNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new ExactSumRealNumbers[]
            {
                new ExactSumRealNumbers(3),
                new ExactSumRealNumbers(2)
            };

            foreach (var item in outputs)
                item.PrintResult();
        }
    }

    public class ExactSumRealNumbers
    {
        private int _ntimes;
        private decimal _sum;

        public ExactSumRealNumbers(int n) => _ntimes = n;

        private void ReceiveNumberNTimes(int n)
        {
            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                CalculateSum(number);
            }
        }

        private void CalculateSum(decimal number) => _sum += number;

        public void PrintResult()
        {
            ReceiveNumberNTimes(_ntimes);
            Console.WriteLine(_sum);
        }
    }
}
