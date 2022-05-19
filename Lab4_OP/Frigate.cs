using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab4_OP
{

    class Frigate:Warship
    {
        public Frigate(int weight, int people, int cannonry) : base(weight, people, cannonry){ }

        public override void Shoot()
        {
            base.Shoot();
            
        }

    }
}
