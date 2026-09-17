namespace Elevator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outputs = new Elevator[3]
            {
                new Elevator(17,3),
                new Elevator(4,5),
                new Elevator(10,5)
            };

            foreach (var item in outputs)
                item.PrintCourseForElevator();
        }
    }

    public class Elevator
    {
        private int _people;
        private int _capacity;

        public Elevator(int people, int capacity)
        {
            this._people = people;
            this._capacity = capacity;
        }

        private int CalculateCourses(int people, int capacity)
        {
            var fullTrips = people / capacity;
            var hasLeftoverPeople = people % capacity != 0;
            return hasLeftoverPeople ? fullTrips + 1 : fullTrips;
        }

        public void PrintCourseForElevator()
        {
            var courses = this.CalculateCourses(this._people, this._capacity);
            Console.WriteLine(courses);
        }
    }
}