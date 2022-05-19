using static System.Console;

namespace Lab4_OP
{
     abstract public class Ship
    {
        public int people { get; set; }
        public int maxWeight { get; set; }

        public Ship(int weight, int people)
        {
            this.maxWeight = weight;
            this.people = people;
        }

        public void PrintMaxPeople()
        {
            WriteLine($"Максимальна кількість людей: {people} осіб");
        }

        public void PrintMaxWeight()
        {
            WriteLine($"Грузопідйомність: {maxWeight} т");
        }

        public void PrintInfo()
        {
            WriteLine(this.GetType().Name);
            PrintMaxPeople();
            PrintMaxWeight();
        }
        
        public void Move()
        {
            WriteLine("Корабель пливе...");
        }


    }

}
