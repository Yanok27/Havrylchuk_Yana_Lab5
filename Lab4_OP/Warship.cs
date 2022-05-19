using System;
using static System.Console;


namespace Lab4_OP
{
    public class Warship: Ship
    {
        public int cannonry { get; set; }

        public Warship(int weight, int people, int cannonry):base(weight, people)
        {
            this.cannonry = cannonry;
        }

        public void PrintCannons()
        {
            WriteLine($"Кількість гармат: {cannonry} одиниць");
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            PrintCannons();
        }


        public virtual void Shoot()
        {
            WriteLine($"Чутно постріли {cannonry} гармат");
           
        }

    }
   
}
