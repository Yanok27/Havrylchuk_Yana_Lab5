﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_2_OP
{
   internal class Diamond:Stone
    {
        public Diamond(string name, int weight, int price, string transperency, int numb)
            : base(name, weight, price, transperency, numb)
        {}
    }
}
