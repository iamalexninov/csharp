namespace Train
{
    public class Program
    {
        static void Main(string[] args)
        {
            Train[] outputs = new Train[3]
            {
                new Train(3),
                new Train(6),
                new Train(1),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class Train
    {
        private int _times;

        public Train(int times) => this._times = times;

        private int[] ReceiveInputsAndFillArr(int times)
        {
            int[] arr = new int[times];
            for (int i = 0; i < times; i++)
            {
                int input = int.Parse(Console.ReadLine());
                arr[i] = input;
            }

            return arr;
        }

        private string PrintElementInArr(int[] arr) => string.Join(" ", arr);

        private int CalculateSum(int[] arr) => arr.Sum();

        public void Sandbox()
        {
            int[] arr = this.ReceiveInputsAndFillArr(this._times);
            Console.WriteLine(this.PrintElementInArr(arr));
            Console.WriteLine(this.CalculateSum(arr));
        }
    }
}