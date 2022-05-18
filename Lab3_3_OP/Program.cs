using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Lab3_3_OP
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/User/Desktop/тт.txt";
            var myList = new List<string>();
            if (File.Exists(path))
            {
                var file = File.ReadAllLines(path);
                foreach (var list in file) myList.Add(list);
                var result = myList.Aggregate("", (x, y) => x + y.First());
                Console.WriteLine("Результат роботи:");
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("Файлу не існує!");
            Console.ReadKey();
        }
    }
}

