namespace ReversedChars
{
    public class Program
    {
        static void Main(string[] args)
        {
            var output = new ReversedChars();
            output.PrintCharacters();
        }
    }

    public class ReversedChars
    {
        private char[] _chars;

        public ReversedChars()
        {
            this._chars = new char[3];
        }

        private void ReadCharacters()
        {
            for (int i = 0; i < 3; i++)
            {
                var letter = char.Parse(Console.ReadLine());
                this.FillArray(letter, i);
            }
        }

        private void FillArray(char letter, int i) => this._chars[i] = letter;

        private void ReverseArray()
        {
            Array.Reverse(this._chars);
        }

        public void PrintCharacters()
        {
            this.ReadCharacters();
            this.ReverseArray();

            Console.Write(String.Join(" ", this._chars));
        }
    }
}

