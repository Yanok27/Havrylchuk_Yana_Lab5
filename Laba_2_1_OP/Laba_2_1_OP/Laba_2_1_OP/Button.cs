using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Button //кнопка
    {
        private string color;
       public string Color { get { return color; }  }
        public Button(string color)
        {
            this.color = color;
        }
        public static void Push(Button bt, int i)
        {
            string res = "Натиснута клавiша кольору : "+ bt.color.ToString() +" номер : " + i.ToString();
            Console.WriteLine(res);
        }
    }
}
