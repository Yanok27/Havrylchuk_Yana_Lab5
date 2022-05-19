using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Lab4_OP
{
    public class Port
    {
        private static List<Ship> ships = new List<Ship>();
        public static void Moor(Ship ship)
        {
            if (ships.Contains(ship)) return;
            ships.Add(ship);
            WriteLine($"{ship.GetType().Name} пришвартовано");
        }

        public static void UnMoor(Ship ship)
        {
            if (!ships.Contains(ship)) return;
            ships.Remove(ship);
            WriteLine($"{ship.GetType().Name} відшвартовано");
        }

        public static void PringShipsCount()
        {
            Console.WriteLine($"\nВ порту {ships.Count} кораблів");
        }

    }
}
