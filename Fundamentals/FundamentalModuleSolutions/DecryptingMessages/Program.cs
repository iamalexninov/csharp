namespace DecryptingMessages
{
    public class Program
    {
        static void Main(string[] args)
        {
            DecryptingMessages[] outputs = new DecryptingMessages[2]
            {
                new DecryptingMessages(3,7),
                new DecryptingMessages(1,7),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class DecryptingMessages
    {
        private int _key;
        private int _nLines;
        private char[] _decrypted;

        public DecryptingMessages(int key, int nLines)
        {
            this._key = key;
            this._nLines = nLines;
            this._decrypted = new char[nLines];
        }

        public void Sandbox()
        {
            for (int i = 0; i < this._nLines; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int parsedCharacterAsNumber = (int)character + this._key;
                this._decrypted[i] = (char)parsedCharacterAsNumber;
            }

            Console.WriteLine(new string(this._decrypted));
        }
    }
}
