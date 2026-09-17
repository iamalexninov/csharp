namespace CenturiesToMinutes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new CenturiesToMinutes[]
            {
                new CenturiesToMinutes(1),
                new CenturiesToMinutes(5)
            };

            foreach (var item in outputs)
                item.PrintResult();
        }
    }

    public class CenturiesToMinutes
    {
        private int _century;
        private int _years;
        private int _days;
        private int _hours;
        private int _minutes;

        public CenturiesToMinutes(int century)
        {
            this._century = century;
            this._years = 1;
            this._days = 1;
            this._hours = 1;
            this._minutes = 1;
        }

        private void ConvertingFromCenturyToMinutes(int century)
        {
            this._years = century * 100;
            this._days = Convert.ToInt32(Math.Round(this._years * 365.2422));
            this._hours = this._days * 24;
            this._minutes = this._hours * 60;
        }

        public void PrintResult()
        {
            this.ConvertingFromCenturyToMinutes(this._century);
            Console.WriteLine($"{this._century} centuries = {this._years} years = {this._days} days = " +
                $"{this._hours} hours = {this._minutes} minutes");
        }
    }
}
