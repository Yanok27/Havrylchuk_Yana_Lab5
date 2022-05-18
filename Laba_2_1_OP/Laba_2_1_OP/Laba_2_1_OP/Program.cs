using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Створення пiанiно.... \nВведiть кiлькiсть бiлих i чорних клавiш через пробiл!");
            int whiteAmount=0, blackAmount=0;
            string input = Console.ReadLine();
            string[] nums = input.Split(" ");
            try {
                whiteAmount = Convert.ToInt32(nums[0]);
                blackAmount = Convert.ToInt32(nums[1]);
            }
            catch{
                Console.WriteLine("Введено не вiрні данi");
            }
            Pianino piano = new Pianino();
            piano.GenerateButtons(whiteAmount, blackAmount);

            Console.WriteLine("Введiть кiлькiсть та типи педалей, через пробiл");
            string inp = Console.ReadLine();
            string[] buff = inp.Split(" ");
            piano.GenerateFoorboard(buff);
            
            Console.WriteLine("Створення пiанiно завершено!");
            Console.WriteLine(piano.ToString());
            Pianino test = new Pianino();
            test.GenerateButtons(3, 3);
            string[] testbuff = new string[] { "1", "s" };
            test.GenerateFoorboard(testbuff);
           
           // test - об'єкт створений для перевірки перезапису методу Equals
            Console.WriteLine(test.ToString());
            Console.WriteLine(Convert.ToString(piano.Equals(test)));
            Console.WriteLine("Перевiрку Equals завершено!");
            while (true)
            {
                Console.WriteLine("Введiть 1 для налаштування пiанiно, 2 для того щоб зiграти, 3 для того, щоб натиснути клавiшу!, 4 для виходу");
                int t = 0;
                try
                {
                    t = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введено не вiрні данi");
                }
                if (t == 1) piano.Configure();
                if (t == 2) piano.Play();
                if (t == 3)
                {
                    var rnd = new Random();
                    int i = rnd.Next(piano.AmountBlack + piano.AmountWhite - 1);
                   // piano.Button_list[rnd.Next(piano.AmountBlack + piano.AmountWhite - 1)].Push();
                    Button.Push(piano.GetButton(i), i+1);
                }
                if (t == 4) Process.GetCurrentProcess().Kill();
            }
        }
    }
}
