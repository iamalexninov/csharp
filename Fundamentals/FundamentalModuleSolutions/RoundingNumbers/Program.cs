namespace RoundingNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            RoundingNumbers[] outputs = new RoundingNumbers[2]
            {
                new RoundingNumbers("0.9 1.5 2.4 2.5 3.14"),
                new RoundingNumbers("-5.01 -1.599 -2.5 -1.50 0"),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class RoundingNumbers
    {
        private string _strOfDoubleNumbers;

        public RoundingNumbers(string str)
        {
            this._strOfDoubleNumbers = str;
        }

        private double[] ConvertStringToDoubleArray(string str) =>
            str.Split(' ').Select(x => double.Parse(x)).ToArray();

        private int RoundNumber(double number) =>
            (int)Math.Round(number, MidpointRounding.AwayFromZero);

        private void PrintResultOfTheConsole(double number, int roundedNumberAwayFromZero) =>
            Console.WriteLine($"{number} => {roundedNumberAwayFromZero}");

        public void Sandbox()
        {
            double[] arr = this.ConvertStringToDoubleArray(this._strOfDoubleNumbers);
            foreach (var item in arr)
            {
                var roundedNumber = this.RoundNumber(item);
                this.PrintResultOfTheConsole(item, roundedNumber);
            }
        }
    }
}



