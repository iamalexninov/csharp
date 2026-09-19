namespace ReverseArrayOfStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReverseArrayOfStrings[] outputs = new ReverseArrayOfStrings[2]
            {
                new ReverseArrayOfStrings("a b c d e"),
                new ReverseArrayOfStrings("-1 hi ho w"),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class ReverseArrayOfStrings
    {
        private string _str;

        public ReverseArrayOfStrings(string str) => this._str = str;

        private string[] ConvertInputStrToArrayStr(string str) => str.Split(' ').ToArray();

        public void Sandbox()
        {
            string[] arr = this.ConvertInputStrToArrayStr(this._str);
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
