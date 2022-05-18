using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Pianino
    {
        private List<Button> button_list;
        private List<Footboard> footboard;
        private int amountWhite, amountBlack;
        public int AmountWhite { get { return amountWhite; } set { amountWhite = value; } }
        public int AmountBlack { get { return amountBlack; } set { amountBlack = value; } }
        public List<Footboard> Footboard { get; set; }
        public List<Button> Button_list { get { return button_list; } set { button_list = value; } }

        public Pianino(List<Button> button_list, List<Footboard> footboard, int amountWhite, int amountBlack)
        {
            this.button_list = button_list;
            this.footboard = footboard;
            this.amountBlack = amountBlack;
            this.amountWhite = amountWhite;
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
