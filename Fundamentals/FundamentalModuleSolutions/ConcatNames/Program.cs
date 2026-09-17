namespace ConcatNames
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new ConcatenationOfNames[3]
            {
                new ConcatenationOfNames("John","Smith","->"),
                new ConcatenationOfNames("Jan","White","<->"),
                new ConcatenationOfNames("Linda","Terry","=>"),
            };

            foreach (var item in outputs)
                item.PrintNamesWithDelimeter();
        }
    }

    public class ConcatenationOfNames
    {
        private string _firstName;
        private string _secondName;
        private string _delimeter;

        public ConcatenationOfNames(string firstName, string secondName, string delimeter)
        {
            this._firstName = firstName;
            this._secondName = secondName;
            this._delimeter = delimeter;
        }

        public void PrintNamesWithDelimeter()
        {
            Console.WriteLine($"{this._firstName}{this._delimeter}{this._secondName}");
        }
    }
}
