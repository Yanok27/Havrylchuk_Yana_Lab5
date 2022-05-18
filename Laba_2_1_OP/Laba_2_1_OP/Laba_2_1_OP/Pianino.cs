using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Pianino
    {
        private List<Button> button_list = new List<Button>();
        private List<Footboard> footboard = new List<Footboard>();
        private int amountWhite, amountBlack;
       
        public int AmountWhite { get { return amountWhite; } }
        public int AmountBlack { get { return amountBlack; } }
       
        public void GenerateFoorboard(string[] buff) 
        {
            try
            {
                int n = Convert.ToInt32(buff[0]);

                for (int i = 1; i <= n; i++)
                {
                    Footboard ftb = new Footboard(buff[i]);
                    footboard.Add(ftb);
                }

            }
            catch
            {
                Console.WriteLine("Введено не вiрні данi");
            }
        }
        public void GenerateButtons(int whiteAmount, int blackAmount)
        {
            amountWhite = whiteAmount;
            amountBlack = blackAmount;
            for (int i = 0; i < whiteAmount; i++)
            {
                Button tmp = new Button("white");
                button_list.Add(tmp);
            }
            for (int i = 0; i < blackAmount; i++)
            {
                Button tmp = new Button("black");
                button_list.Add(tmp);
            }
        }
        public Pianino( )
        {
           
        }
        public Button GetButton(int index)
        {
            return button_list[index];
        }
        public override string ToString()
        {
            string res = "";
            res += "У пiанiно " + Convert.ToString(button_list.Count()) + " клавiш\n";
            res += "З них бiлих: " + Convert.ToString(amountWhite) + " чорних : " + Convert.ToString(amountBlack) + "\n";
            res += "Педалей : " + this.footboard.Count() + " таких типiв : ";
            foreach(var ft in footboard)
            {
                res += ft.Oriention + " ";
            }

            return res;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Pianino)) return false;
            if (this.footboard.Count != ((Pianino)obj).footboard.Count) return false;
            for (int i = 0; i < this.footboard.Count; i++)
            {
                if (this.footboard[i].Oriention != ((Pianino)obj).footboard[i].Oriention) return false;
            }
            return (this.amountBlack == ((Pianino)obj).amountBlack) && (this.amountWhite == ((Pianino)obj).amountWhite);

        }

        public override int GetHashCode()
        {
            return this.footboard.GetHashCode() ^ this.amountWhite.GetHashCode() ^ this.amountBlack.GetHashCode();
        }

        public void Configure()
        {
            Console.WriteLine("Пiанiно налаштовано!");
        }

        public void Play()
        {
            Console.WriteLine("До-ре-мі-фа-соль....\nНа піаніно було зіграно!");
        }
    }
}
