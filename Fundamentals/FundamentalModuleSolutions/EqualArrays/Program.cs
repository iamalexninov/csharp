namespace EqualArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            EqualArrays[] outputs = new EqualArrays[3]
            {
                new EqualArrays("10 20 30", "10 20 30"),
                new EqualArrays("1 2 3 4 5", "1 2 4 3 5"),
                new EqualArrays("1", "10"),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class EqualArrays
    {
        private int[] _firstArr;
        private int[] _secondArr;
        private bool isIdentical;
        private int _sum;

        public EqualArrays(string firstSequence, string secondSequence)
        {
            this._firstArr = firstSequence.Split(' ').Select(int.Parse).ToArray();
            this._secondArr = secondSequence.Split(' ').Select(int.Parse).ToArray();
            this.isIdentical = true;
            this._sum = 0;
        }

        private string IsArraysEqual(int[] firstArr, int[] secondArr, int sum)
        {
            string result = "";
            for (int i = 0; i < this._firstArr.Length; i++)
            {
                if (this._firstArr[i] != this._secondArr[i])
                {
                    isIdentical = false;
                    result = $"Arrays are not identical. Found difference at {i} index";
                    break;
                }
                else
                {
                    sum = this.CalculateSumOfIdenticalArrays(firstArr[i], sum);
                }
            }

            if (isIdentical)
                result = $"Arrays are identical. Sum: {sum}";

            return result;
        }

        private int CalculateSumOfIdenticalArrays(int number, int sum) => sum += number;
        public void Sandbox() => Console.WriteLine(this.IsArraysEqual(this._firstArr, this._secondArr, this._sum));
    }
}
