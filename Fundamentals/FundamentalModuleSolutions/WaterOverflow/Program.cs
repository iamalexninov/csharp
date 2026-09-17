namespace WaterOverflow
{
    public class Program
    {
        static void Main(string[] args)
        {
            WaterOverflow[] outputs = new WaterOverflow[4]
            {
                new WaterOverflow(5),
                new WaterOverflow(1),
                new WaterOverflow(7),
                new WaterOverflow(4)
            };

            foreach (var item in outputs)
                item.PourWaterPrintCapacity();
        }
    }

    public class WaterOverflow
    {
        private int _maxLitersCapacity = 255;
        private int _nLines;

        public WaterOverflow(int n)
        {
            this._nLines = n;
        }

        public void PourWaterPrintCapacity()
        {
            int finalPourLiters = 0;
            for (int i = 0; i < this._nLines; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());

                if (finalPourLiters + litersToPour > this._maxLitersCapacity)
                {
                    Console.WriteLine("Unsufficient capacity!");
                }
                else
                {
                    finalPourLiters += litersToPour;
                }
            }

            Console.WriteLine(finalPourLiters);
        }
    }
}

