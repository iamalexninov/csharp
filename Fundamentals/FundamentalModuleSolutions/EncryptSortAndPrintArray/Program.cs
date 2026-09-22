using System.Reflection.Metadata;

namespace EncryptSortPrintArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            EncryptSortPrintArray[] outputs = new EncryptSortPrintArray[2]
            {
                new EncryptSortPrintArray(4),
                new EncryptSortPrintArray(3),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class EncryptSortPrintArray
    {
        private int _readN;
        private string vowelLetters = "aeiouAEIOU";
        private int[] _arr;

        public EncryptSortPrintArray(int n)
        {
            this._readN = n;
            this._arr = new int[n];
        }

        public void Sandbox()
        {
            int vowel = 0;
            int consonant = 0;

            for (int i = 0; i < this._readN; i++)
            {
                char[] ch = Console.ReadLine().ToCharArray();

                for (int j = 0; j < ch.Length; j++)
                {
                    if (vowelLetters.Contains(ch[j]))
                    {
                        vowel += (int)ch[j] * ch.Length;
                    }
                    else
                    {
                        consonant += (int)ch[j] / ch.Length;
                    }
                }

                this._arr[i] = vowel + consonant;

                vowel = 0;
                consonant = 0;
            }

            Array.Sort(this._arr);
            foreach (var item in this._arr)
                Console.WriteLine(item);
        }
    }
}