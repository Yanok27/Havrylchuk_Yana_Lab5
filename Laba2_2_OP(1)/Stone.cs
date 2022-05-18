using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_2_OP
{
    public class Stone
    {
		public string name;			//ім'я каменю
		public double weight;		//вага каменю
		public int price;			//ціна
		public string transparency;	//параметр прозорості
		public int number;          //цінність
		

		public Stone(string name, int weight, int price, string transperency, int numb)
		{
			this.name = name;
			this.weight = weight;
			this.price = price;
			this.transparency = transperency;
			this.number = numb;
			
		}
		

		

	}
}

