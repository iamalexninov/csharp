namespace LowerToUpper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new LowerToUpper[2]
            {
                new LowerToUpper('L'),
                new LowerToUpper('f'),
            };

            foreach (var item in outputs)
                item.PrintCaseSensitivity();
        }
    }

    public class LowerToUpper
    {
        private char _character;

        public LowerToUpper(char character)
        {
            this._character = character;
        }

        public void PrintCaseSensitivity()
        {
            if (char.IsUpper(this._character))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
