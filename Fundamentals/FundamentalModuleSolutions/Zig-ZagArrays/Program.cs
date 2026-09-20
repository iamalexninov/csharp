namespace ZigZag
{
    public class ZigZag
    {
        static void Main(string[] args)
        {
            ZigZagArrays[] outputs = new ZigZagArrays[2] {
                new ZigZagArrays(4),
                new ZigZagArrays(2),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class ZigZagArrays
    {
        private int _times;
        private int[] _arr1;
        private int[] _arr2;

        public ZigZagArrays(int times)
        {
            this._times = times;
            this._arr1 = new int[times];
            this._arr2 = new int[times];
        }

        private void ReadElementsFromConsole(int times)
        {
            for (int i = 0; i < times; i++)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    this._arr1[i] = inputs[0];
                    this._arr2[i] = inputs[1];
                }
                else
                {
                    this._arr1[i] = inputs[1];
                    this._arr2[i] = inputs[0];
                }
            }
        }

        public void Sandbox()
        {
            this.ReadElementsFromConsole(this._times);
            Console.WriteLine(String.Join(" ", this._arr1));
            Console.WriteLine(String.Join(" ", this._arr2));
        }
    }
}