namespace SumOfChars
{
    public class Program
    {
        static void Main(string[] args)
        {
            SumChars[] outputs = new SumChars[]
            {
                new SumChars(5),
                new SumChars(12),
            };

            foreach (var item in outputs)
                item.PrintSumOfCharacters();
        }
    }

    public class SumChars
    {
        private int _n;
        private int _sum;

        public SumChars(int n)
        {
            this._n = n;
            this._sum = 0;
        }

        private int CalculateSumOfCharacters(int n, int sum)
        {
            for (int i = 1; i <= n; i++)
            {
                char characterFromConsole = char.Parse(Console.ReadLine());
                //(int) - conve
                int number = (int)characterFromConsole;
                sum += number;
            }

            return sum;
        }

        public void PrintSumOfCharacters()
        {
            int finalSum = this.CalculateSumOfCharacters(this._n, this._sum);
            Console.WriteLine($"The sum equals: {finalSum}");
        }

    }
}
