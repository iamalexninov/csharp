namespace PrimeChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            IsPrime[] outputs = new IsPrime[1]
            {
                new IsPrime(5),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class IsPrime
    {
        private int _number;

        public IsPrime(int number)
        {
            this._number = number;
        }

        public void Sandbox()
        {
            for (int i = 2; i <= this._number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", i, isPrime);
            }
        }
    }
}
