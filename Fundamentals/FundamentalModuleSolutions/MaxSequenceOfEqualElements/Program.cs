namespace MaxSequenceOfEqualElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            MaxSequenceOfEqualElements[] outputs = new MaxSequenceOfEqualElements[4]
            {
                new MaxSequenceOfEqualElements("2 1 1 2 3 3 2 2 2 1"),
                new MaxSequenceOfEqualElements("1 1 1 2 3 1 3 3"),
                new MaxSequenceOfEqualElements("4 4 4 4"),
                new MaxSequenceOfEqualElements("0 1 1 5 2 2 6 3 3"),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class MaxSequenceOfEqualElements
    {
        private int[] _arr;

        public MaxSequenceOfEqualElements(string str) =>
            this._arr = str.Split(' ').Select(int.Parse).ToArray();

        public void Sandbox()
        {
            if (_arr.Length == 0) return;

            int bestStart = 0, bestLength = 1;
            int currentStart = 0, currentLength = 1;

            for (int i = 1; i < _arr.Length; i++)
            {
                int a = _arr[i];
                int b = _arr[i - 1];

                if (a == b)
                {
                    currentLength++;
                }
                else
                {
                    currentStart = i;      // a new sequence begins here
                    currentLength = 1;
                }

                if (currentLength > bestLength)   // strictly greater keeps the leftmost
                {
                    bestStart = currentStart;
                    bestLength = currentLength;
                }
            }

            Console.WriteLine(string.Join(" ", _arr.Skip(bestStart).Take(bestLength)));
        }
    }
}