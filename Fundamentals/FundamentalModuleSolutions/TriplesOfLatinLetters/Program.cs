namespace TriplesOfLatinLetters
{
    public class Program
    {
        static void Main(string[] args)
        {
            TriplesLetters[] outputs = new TriplesLetters[1]
            {
                new TriplesLetters(3),
            };

            foreach (var item in outputs)
                item.PrintTriplesLetters();
        }
    }

    public class TriplesLetters
    {
        private int _n;

        public TriplesLetters(int n)
        {
            this._n = n;
        }

        public void PrintTriplesLetters()
        {
            for (int i = 0; i < this._n; i++)
            {
                for (int j = 0; j < this._n; j++)
                {
                    for (int k = 0; k < this._n; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }

        }
    }
}
