namespace CondenseArrayToNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            CondenseArrayToNumber[] outputs = new CondenseArrayToNumber[3]
            {
                new CondenseArrayToNumber("2 10 3"),
                new CondenseArrayToNumber("5 0 4 1 2"),
                new CondenseArrayToNumber("1"),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class CondenseArrayToNumber
    {
        private int[] _arr;

        public CondenseArrayToNumber(string str) =>
            this._arr = str.Split(' ').Select(int.Parse).ToArray();

        public void Sandbox()
        {
            while (this._arr.Length != 1)
            {
                int[] condensed = new int[this._arr.Length];
                for (int i = 0; i < this._arr.Length - 1; i++)
                {
                    condensed[i] = this._arr[i] + this._arr[i + 1];
                }

                this._arr = condensed.Where(x => x != 0).ToArray();
            }

            Console.WriteLine(this._arr.Sum());
        }
    }
}
