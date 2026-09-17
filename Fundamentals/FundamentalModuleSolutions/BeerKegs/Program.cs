namespace BeerKegs
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new BeerKegs[2]
            {
                new BeerKegs(3),
                new BeerKegs(2),
            };

            foreach (var item in outputs)
                item.PrintBiggestKegModel();
        }
    }

    public class BeerKegs
    {
        private int _n;
        private string _biggestKegModel;
        private double _biggestKegVolume;

        public BeerKegs(int n) => this._n = n;
        
        private void CalculateBiggestKeg(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentKegVolume = Math.PI * radius * radius * height;

                if (this._biggestKegVolume < currentKegVolume)
                {
                    this._biggestKegVolume = currentKegVolume;
                    this._biggestKegModel = model;
                }
            }
        }

        public void PrintBiggestKegModel()
        {
            this.CalculateBiggestKeg(this._n);
            Console.WriteLine(this._biggestKegModel);
        }
    }
}
