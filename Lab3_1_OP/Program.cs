using System;
using System.Collections.Generic;


namespace Lab3_1_OP
{
    class Program
    {
        static void Main(string[] args)
        {
            int pair;
            Console.WriteLine("Введіть кількість елементів у списку:");
            int value = Convert.ToInt32(Console.ReadLine());
            List<string> myList = new List<string>();
            Console.WriteLine("Введіть елементи списку:");
            
            for( int i=0; i < value; i++)
            {
                myList.Add(Console.ReadLine());

            }
            Console.WriteLine("Отриманий список:");
            Console.WriteLine(string.Join("   ", myList));
            
            
            if (value % 2 == 0)
            {

                pair = value;
               
            }

            else
            {
                pair = value - 1;
                
            }
           
            for (int i = 0; i < pair; i = i + 2)
            {
                string element = myList[i];
                myList[i] = myList[i + 1];
                myList[i + 1] = element;
            }

            Console.WriteLine("Кінцевий результат:");
            foreach (string elem in myList)
            {
                Console.WriteLine(elem);
            }

        }
    }
}
           

            
        
    

