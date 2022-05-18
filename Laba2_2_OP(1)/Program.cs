using System;
using System.Collections.Generic;

namespace Laba2_2_OP
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Necklace necklace=new Necklace();
            Console.WriteLine("\t\t\t\t\tВиди каменів:\n1-diamond;\n2-emerald;\n3-sapphire;\n4-ruby;");
            

            Console.WriteLine("Скільки видів каменів ви хочете?(вкажіть цифру не більше 4)");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               necklace.Create_Necklace();
            }
            
            necklace.Our_Necklace();
            necklace.Weight_Price();
            necklace.Sort();
            necklace.Find();
        }
    }
}
