using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Footboard // педаль
    {
        public string oriention;
        public string Oriention { get { return oriention; } set { oriention = value; } }
        public Footboard(string oriention)
        {
            this.oriention = oriention;
        }
    }
}
