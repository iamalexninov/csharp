namespace CharsToString
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new CharsToString[3]
            {
                new CharsToString('a','b','c'),
                new CharsToString('%','2','o'),
                new CharsToString('1','5','p'),
            };

            foreach (var item in outputs)
                item.PrintExactResult();
        }
    }

    public class CharsToString
    {
        private char _first;
        private char _second;
        private char _third;

        public CharsToString(char first, char second, char third)
        {
            this._first = first;
            this._second = second;
            this._third = third;
        }

        public void PrintExactResult()
        {
            char[] arr = new char[3] { this._first, this._second, this._third };
            string result = string.Join("", arr);
            Console.WriteLine(result);
        }
    }
}
