namespace PoundsToDollars
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new PoundsToDollars[]
            {
                new PoundsToDollars(80),
                new PoundsToDollars(39),
            };

            foreach (var item in outputs)
                item.PrintResultOnTheConsole();
        }
    }

    public class PoundsToDollars
    {
        private int _pounds;
        private double exchangeRate = 1.31;

        public PoundsToDollars(int pounds) =>
            this._pounds = pounds;

        private double ConvertPoundsToDollars(int pounds) => pounds * exchangeRate;

        private string FormmatResultToThirdDecimalPoint() =>
            this.ConvertPoundsToDollars(this._pounds).ToString("F3");

        public void PrintResultOnTheConsole() =>
            Console.WriteLine(this.FormmatResultToThirdDecimalPoint());
    }
}

// The goal: To create a program that converts british pounds to dollarrs - formatted to the 3rd decimal point
// Describing: 
// 1. Input - british pounds - int
// 2. Variable for the exchange rate is 1 pound = 1.31 dollar
// 3. Function for converting 
// 4. Function for formatting to the 3rd dec.point
// 5. Function for final result
