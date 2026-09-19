namespace EvenAndOddSubtraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            EvenAndOddSubtraction[] outputs = new EvenAndOddSubtraction[3]
            {
                new EvenAndOddSubtraction("1 2 3 4 5 6"),
                new EvenAndOddSubtraction("3 5 7 9"),
                new EvenAndOddSubtraction("2 4 6 8 10"),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class EvenAndOddSubtraction
    {
        private int[] _arr;
        public EvenAndOddSubtraction(string str) =>
            this._arr = str.Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
        private int CalculateEvenSum(int[] arr) => arr.Where(x => x % 2 == 0).Sum();
        private int CalculateOddSum(int[] arr) => arr.Where(x => x % 2 != 0).Sum();
        private int CalculateSubtraction() => this.CalculateEvenSum(this._arr) - this.CalculateOddSum(this._arr);
        public void Sandbox() => Console.WriteLine(this.CalculateSubtraction());
    }
}
