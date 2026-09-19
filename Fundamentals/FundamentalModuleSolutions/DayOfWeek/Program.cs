namespace DayOfWeek
{
    public class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek[] outputs = new DayOfWeek[3]
            {
                new DayOfWeek(1),
                new DayOfWeek(2),
                new DayOfWeek(10),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class DayOfWeek
    {
        private int _numberRepresentsDayOfWeek;

        public DayOfWeek(int number)
        {
            this._numberRepresentsDayOfWeek = number;
        }

        public void Sandbox()
        {
            var daysOfWeek = new[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine(this._numberRepresentsDayOfWeek <= 7 ? daysOfWeek[this._numberRepresentsDayOfWeek - 1] : "Invalid day!");
        }
    }
}
