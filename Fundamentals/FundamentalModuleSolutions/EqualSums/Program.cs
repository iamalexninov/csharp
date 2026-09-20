namespace EqualSums
{
    public class Program
    {
        static void Main(string[] args)
        {
            EqualSums[] outputs = new EqualSums[5]
            {
                new EqualSums("1 2 3 3"),
                new EqualSums("1 2"),
                new EqualSums("1"),
                new EqualSums("1 2 3"),
                new EqualSums("10 5 5 99 3 4 2 5 1 1 4"),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class EqualSums
    {
        private int[] _arr;
        private bool _isEqual;
        private int _index;

        public EqualSums(string str)
        {
            this._arr = str.Split(' ').Select(int.Parse).ToArray();
        }

        public void Sandbox()
        {

            for (int i = 0; i < this._arr.Length; i++)
            {
                int leftSum = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (j >= 0)
                    {
                        leftSum += this._arr[j];
                    }
                }

                int rightSum = 0;
                for (int j = i + 1; j < this._arr.Length; j++)
                    rightSum += this._arr[j];

                if (rightSum == leftSum)
                {
                    this._index = i;
                    this._isEqual = true;
                    break;
                }
                else
                {
                    this._isEqual = false;
                }
            }

            if (this._arr.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(this._isEqual ? this._index : "no");
            }
        }
    }
}