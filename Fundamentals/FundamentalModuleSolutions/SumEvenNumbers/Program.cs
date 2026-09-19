namespace SumEvenNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            SumEvenNumbers[] outputs = new SumEvenNumbers[3]
            {
                new SumEvenNumbers("1 2 3 4 5 6"),
                new SumEvenNumbers("3 5 7 9"),
                new SumEvenNumbers("2 4 6 8 10"),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class SumEvenNumbers
    {
        private int[] _arr;

        public SumEvenNumbers(string str) =>
            this._arr = str
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToArray();

        private int CalculateEvenSum(int[] arr) => arr.Where(x => x % 2 == 0).Sum();
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        public void Sandbox() => Console.WriteLine(this.CalculateEvenSum(this._arr));
    }
}
