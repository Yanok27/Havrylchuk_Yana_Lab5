using System;

namespace Lab4_OP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Frigate frig = new Frigate(15, 200, 5);
            frig.PrintInfo();
            Port.Moor(frig);
            frig.Shoot();
            Console.WriteLine(" ");

            CargoShip cargo = new CargoShip(100, 150);
            cargo.PrintInfo();
            Port.Moor(cargo);
            Console.WriteLine(" ");

            Warship war = new Warship(20, 50, 10);
            war.PrintInfo();
            war.Shoot();
            Console.WriteLine(" ");

            Ferry fer = new Ferry(150, 500);
            fer.PrintInfo();
            fer.Move();

            Port.PringShipsCount();

        }
    }
}
