namespace MagicSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            MagicSum[] outputs = new MagicSum[2]
            {
                new MagicSum("1 7 6 2 19 23", 8),
                new MagicSum("14 20 60 13 7 19 8", 27),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class MagicSum
    {
        private int[] _arr;
        private int _uniqueNum;

        public MagicSum(string sequenceStr, int number)
        {
            this._arr = sequenceStr.Split(' ').Select(int.Parse).ToArray();
            this._uniqueNum = number;
        }

        public void Sandbox()
        {
            for (int i = 0; i < this._arr.Length; i++)
            {
                int firstElement = this._arr[i];

                for (int j = i + 1; j < this._arr.Length; j++)
                {
                    if (j == this._arr.Length)
                        break;

                    int nextElement = this._arr[j];

                    if (firstElement + nextElement == this._uniqueNum)
                    {
                        Console.WriteLine($"{firstElement} {nextElement}");
                    }
                }
            }
        }
    }
}