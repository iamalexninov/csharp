namespace FloatingEquality
{
    public class Program
    {
        static void Main(string[] args)
        {
            FloatingEquality[] outputs = new FloatingEquality[6]
            {
                new FloatingEquality(5.3, 6.01),
                new FloatingEquality(5.00000001, 5.00000003),
                new FloatingEquality(5.00000005, 5.00000001),
                new FloatingEquality(-0.0000007, 0.00000007),
                new FloatingEquality(-4.999999, -4.999998),
                new FloatingEquality(4.999999, 4.999998),
            };

            foreach (var item in outputs)
                item.Sandbox(); 
        }
    }

    public class FloatingEquality
    {
        private double _firstNumber;
        private double _secondNumber;

        public FloatingEquality(double firstNumber, double secondNumber)
        {
            this._firstNumber = firstNumber;
            this._secondNumber = secondNumber;
        }

        public void Sandbox()
        {
            double eps = 0.000001;
            double resultBetweenSubstraction = 0;
            bool equal = false;

            if (this._firstNumber > this._secondNumber)
            {
                resultBetweenSubstraction = this._firstNumber - this._secondNumber;
            }
            else
            {
                resultBetweenSubstraction = this._secondNumber - this._firstNumber;
            }

            if (resultBetweenSubstraction < eps)
            {
                equal = true;
            }

            if (equal)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
