namespace IntegerOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new IntegerOperations[2]
            {
                new IntegerOperations(10,20,3,3),
                new IntegerOperations(15,14,2,3)
            };

            foreach (var item in outputs)
                item.PrintIntegerOperatinos();
        }
    }

    public class IntegerOperations
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _thirdNumber;
        private int _fourthNumber;

        public IntegerOperations(int first, int second, int third, int fourth)
        {
            this._firstNumber = first;
            this._secondNumber = second;
            this._thirdNumber = third;
            this._fourthNumber = fourth;
        }

        public void PrintIntegerOperatinos()
        {
            var add = this._firstNumber + this._secondNumber;
            var divide = add / this._thirdNumber;
            var multiply = divide * this._fourthNumber;

            Console.WriteLine(multiply);
        }
    }
}
