namespace Snowballs
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new Snowballs[2]
            {
                new Snowballs(2),
                new Snowballs(3)
            };

            foreach (var item in outputs)
                item.PrintResult();
        }
    }

    public class Snowballs
    {
        private int _madeShowballsByTonyAndAndi;
        private int _snowballHighestValue;
        private int _snowballHighestSnow;
        private int _snowballHighestTime;
        private int _snowballHighestQuantity;

        public Snowballs(int n)
        {
            this._madeShowballsByTonyAndAndi = n;
            this._snowballHighestValue = 0;
        }

        private void CalculateSnowballsValue()
        {
            for (int i = 0; i < this._madeShowballsByTonyAndAndi; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());

                // Math.Pow(snowballSnow / snowballTime, snowballQuality) - степенуване на частно
                int currentSnowballValue = Convert.ToInt32(Math.Pow(snowballSnow / snowballTime, snowballQuality));

                if (currentSnowballValue > this._snowballHighestValue)
                {
                    this._snowballHighestValue = currentSnowballValue;
                    this._snowballHighestSnow = snowballSnow;
                    this._snowballHighestTime = snowballTime;
                    this._snowballHighestQuantity = snowballQuality;
                }
            }
        }

        public void PrintResult()
        {
            this.CalculateSnowballsValue();
            Console.WriteLine($"{this._snowballHighestSnow} : {this._snowballHighestTime} = {this._snowballHighestValue} ({this._snowballHighestQuantity})");
        }
    }
}

/*
Notes and thinking: 
1. Receiving N - an integer for number of snowballs that are make by Tony and Andi.
2. For each showball - receiving 3 input lines.
[] - 3 lines for 1 snowball
[] - firstline - snowballSnow
[] - secondline - snowballTime
[] - thirdline - snowballQuality
3. For each snowball calculate snowballValue by this formula: (snowballSnow / snowballTime) ^ snowballQuality
4. Print highest calculated - snowballValue - which means that I should save each snowball value and make a conditional statement to execute the highest snowball.
Output: {snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})
*/
