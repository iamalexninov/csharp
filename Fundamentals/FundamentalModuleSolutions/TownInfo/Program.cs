namespace TownInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new TownInfo[2]
            {
                new TownInfo("Sofia", 1286383, 492),
                new TownInfo("Kaliningrad",437456,223)
            };

            foreach (var item in outputs)
                item.PrintFormattingText();
        }
    }

    public class TownInfo
    {
        private string _town;
        private int _population;
        private int _area;

        public TownInfo(string town, int population, int area)
        {
            this._town = town;
            this._population = population;
            this._area = area;
        }

        public void PrintFormattingText()
        {
            Console.WriteLine($"Town {this._town} has population of {this._population} and area {this._area} square km.");
        }
    }
}
