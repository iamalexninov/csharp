namespace Pokemon
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new Pokemon[2]
            {
                new Pokemon(5,2,3),
                new Pokemon(10,5,2)
            };

            foreach (var item in outputs)
                item.PrintResult();
        }
    }

    public class Pokemon
    {
        private int _n;
        private int _m;
        private int _y;
        private int _counter;
        private int _initialPokemonPower;

        public Pokemon(int n, int m, int y)
        {
            this._n = n;
            this._m = m;
            this._y = y;
            this._initialPokemonPower = n;
        }

        private void Sandbox()
        {
            while (this._n >= this._m)
            {
                this._n -= this._m;
                this._counter++;
                bool isHalfOfInitialPower = this._n == this._initialPokemonPower / 2;
                if (isHalfOfInitialPower)
                {
                    this._n = this._n / this._y;
                }

                
            }
        }

        public void PrintResult()
        {
            this.Sandbox();
            Console.WriteLine(this._n);
            Console.WriteLine(this._counter);
        }
    }
}
