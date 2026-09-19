namespace PrintNumbersInReverseOrder
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintNumbersInReverseOrder[] outputs = new PrintNumbersInReverseOrder[3]
            {
                new PrintNumbersInReverseOrder(3),
                new PrintNumbersInReverseOrder(3),
                new PrintNumbersInReverseOrder(1),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class PrintNumbersInReverseOrder
    {
        private int _readNumbers;
        private int[] _arr;

        public PrintNumbersInReverseOrder(int n)
        {
            this._readNumbers = n;
            this._arr = new int[n];
        }

        private void FillArrWithNumbers()
        {
            for (int i = 0; i < this._readNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                this._arr[i] = number;
            }
        }

        public void Sandbox()
        {
            this.FillArrWithNumbers();
            Array.Reverse(this._arr);
            Console.WriteLine(string.Join(" ", this._arr));
        }
    }
}
