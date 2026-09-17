namespace PrintPartOfTheAsciiTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            ASCIITable[] outputs = new ASCIITable[2]
            {
                new ASCIITable(60,65),
                new ASCIITable(35,49),
            };

            foreach (var item in outputs)
                item.PrintPartOfASCII();
        }
    }

    public class ASCIITable
    {
        private int _startIndex;
        private int _endIndex;

        public ASCIITable(int startIndex, int endIndex)
        {
            this._startIndex = startIndex;
            this._endIndex = endIndex;
        }

        public void PrintPartOfASCII()
        {
            for (int i = this._startIndex; i <= this._endIndex; i++)
            {
                char text = (char)i;
                Console.Write(text + " ");
            }

            Console.WriteLine();
        }
    }
}
