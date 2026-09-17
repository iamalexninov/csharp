using System.Runtime.Intrinsics.X86;

namespace SpiceMustFlow
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new SpiceMustFlow[2]
            {
                new SpiceMustFlow(111),
                new SpiceMustFlow(450),
            };

            foreach (var item in outputs)
                item.PrintResult();
        }
    }

    public class SpiceMustFlow
    {
        private int _yield;
        private int _totalAmount;
        private int _days;

        public SpiceMustFlow(int yield)
        {
            this._yield = yield;
        }

        private void IterateThroughYield()
        {
            while (this._yield >= 100)
            {

                int currentMinedSpice = this._yield - 26;
                this.CalculateTotalDaysOfMineWork(1);
                this.CalculateTotalAmountOfExtractedSpice(currentMinedSpice);

                this._yield -= 10;
            }

            this._totalAmount -= 26;
        }

        private void CalculateTotalAmountOfExtractedSpice(int currentSpice)
        {
            this._totalAmount += currentSpice;
        }

        private void CalculateTotalDaysOfMineWork(int days)
        {
            this._days += days;
        }

        public void PrintResult()
        {
            this.IterateThroughYield();
            Console.WriteLine(this._days);
            Console.WriteLine(this._totalAmount);
        }
    }
}


// [x]-What I learned from this example: 
// Use for when you know the number of iterations in advance (looping over an array by index, repeating something exactly N times).
// Use while when the loop should continue based on a changing condition and you don't know ahead 
// of time how many passes it'll take (your case — you don't know how many times yield will drop by 10 before dropping below 100).