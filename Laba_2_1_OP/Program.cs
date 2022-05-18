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
            List<Button> btnlist = new List<Button>();
            for(int i = 0; i < whiteAmount; i++)
            {
                Button tmp = new Button("white");
                btnlist.Add(tmp);
            }
            for (int i = 0; i < blackAmount; i++)
            {
                Button tmp = new Button("black");
                btnlist.Add(tmp);
            }
            Console.WriteLine("Введiть кiлькiсть та типи педалей, через пробiл");
            string inp = Console.ReadLine();
            string[] buff = inp.Split(" ");
            List<Footboard> ftblist = new List<Footboard>();
            try
            {
                int n = Convert.ToInt32(buff[0]);
               
                for(int i = 1; i <= n; i++)
                {
                    Footboard ftb = new Footboard(buff[i]);
                    ftblist.Add(ftb);
                }
                
            }
            catch
            {
                Console.WriteLine("Введено не вiрні данi");
            }
            Pianino piano = new Pianino(btnlist, ftblist, whiteAmount, blackAmount);
            Console.WriteLine("Створення пiанiно завершено!");
            Console.WriteLine(piano.ToString());
            List<Button> test_1 = new List<Button>();
            for (int i = 0; i < 3; i++)
            {
                Button tmp = new Button("white");
                test_1.Add(tmp);
            }
            for (int i = 0; i < 3; i++)
            {
                Button tmp = new Button("black");
                test_1.Add(tmp);
            }
            List<Footboard> test_2 = new List<Footboard>(); 
            Footboard f = new Footboard("s");
            test_2.Add(f);
            Pianino test = new Pianino(test_1, test_2, 3, 3);// test - об'єкт створений для перевірки перезапису методу Equals
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
                    Button.Push(piano.Button_list[i], i+1);
                }
                if (t == 4) Process.GetCurrentProcess().Kill();
            }
        }
    }
}
