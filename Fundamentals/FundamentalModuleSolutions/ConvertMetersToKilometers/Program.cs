namespace ConvertMetersToKilometers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new ConvertMetersToKilometers[] {
                new ConvertMetersToKilometers(1852),
                new ConvertMetersToKilometers(798),
            };

            foreach (var item in outputs)
                item.PrintCalculatedKilometers();
        }

        public class ConvertMetersToKilometers
        {
            private int meters;

            public ConvertMetersToKilometers(int meters)
            {
                this.meters = meters;
            }

            private string CalculateKilometers(int meters) => (meters / 1000.0).ToString("F2");

            public void PrintCalculatedKilometers() =>
                Console.WriteLine(this.CalculateKilometers(this.meters));
        }
    }
}


// input - distance in meters
// main goal - 
// - meters / 1000 = kilometers
// 2th decimal point