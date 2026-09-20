namespace TopIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            TopIntegers[] outputs = new TopIntegers[3] {
                new TopIntegers("1 4 3 2"),
                new TopIntegers("14 24 3 19 15 17"),
                new TopIntegers("27 19 42 2 13 45 48"),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class TopIntegers
    {
        private int[] _arr;

        public TopIntegers(string str)
        {
            this._arr = str.Split(' ').Select(int.Parse).ToArray();
        }

        public void Sandbox()
        {
            for (int i = 0; i < this._arr.Length; i++)
            {
                int topInteger = 0;
                for (int j = i + 1; j < this._arr.Length; j++)
                {
                    int firstElement = this._arr[i];
                    int currentElement = this._arr[j];

                    if (firstElement < currentElement)
                    {
                        this._arr[i] = 0;
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", this._arr.Where(x => x > 0)));
        }
    }
}