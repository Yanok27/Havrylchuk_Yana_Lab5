using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_2_OP
{
    class Necklace

    {
		public List<Stone> necklace;
		public Necklace()
        {
			necklace = new List<Stone>();
		}

		public void Create_Necklace()
		{
			Console.WriteLine("Виберіть, які дорогоцінні камені Ви хочете бачити у своєму намисті:");
			string name = Console.ReadLine();

			if (name == "diamond")
			{
				Console.WriteLine("Кількість каменів обраного виду:");
				int dia = Convert.ToInt32(Console.ReadLine());
				Diamond diamond = new Diamond("diamond", 1, 100, "transperent", dia);
				necklace.Add(diamond);
			}
			else if (name == "ruby")
			{
				Console.WriteLine("Кількість каменів обраного виду :");
				int rub = Convert.ToInt32(Console.ReadLine());
				Ruby ruby = new Ruby("ruby", 4, 50, "opaque", rub);
				necklace.Add(ruby);
			}
			else if (name == "emerald")
			{
				Console.WriteLine("Кількість каменів обраного виду :");
				int eme = Convert.ToInt32(Console.ReadLine());
				Emerald emerald = new Emerald("emerald", 3, 75, "translucent", eme);
				necklace.Add(emerald);
			}
			else if (name == "sapphire")
			{
				Console.WriteLine("Кількість каменів обраного виду :");
				int sap = Convert.ToInt32(Console.ReadLine());
				Sapphire sapphire = new Sapphire("sapphire", 3, 200, "opaque", sap);
				necklace.Add(sapphire);
			}
			else
			{
				Console.WriteLine("Введено невірні дані!");
			}
		}


		public void Our_Necklace()
		{
			Console.WriteLine();
			Console.WriteLine("Намисто:\nВиди каміння\t\t\t\tВага\t\t\tЦіна");
			for (int i = 0; i < necklace.Count; i++)
			{
				Console.WriteLine(necklace[i].name + "\t - \t" + necklace[i].number + " stone(s) \t- \t" + necklace[i].weight + " carats \t- \t" + necklace[i].price + " $");
			}
		}

		public void Weight_Price()
		{
			Console.WriteLine();
			double summ_weight = 0;
			double summ_price = 0;
			for (int i = 0; i < necklace.Count; i++)
			{
				summ_weight += necklace[i].number * necklace[i].weight;
				summ_price += necklace[i].number * necklace[i].weight * necklace[i].price;
			}
			Console.WriteLine("Загальна вага: " + summ_weight + " каратів");
			Console.WriteLine("Загальна сума: " + summ_price + " $");
		}

		public void Sort()
		{
			for (int i = necklace.Count - 1; i > -1; i--)
			{
				for (int j = 0; j < i; j++)
				{
					if (necklace[j].price > necklace[j + 1].price)
					{
						(necklace[j], necklace[j + 1]) = (necklace[j + 1], necklace[j]);
					}
				}
			}
			Console.WriteLine("Відсортоване каміння за цінністю:");
			for (int i = 0; i < necklace.Count; i++)
			{
				Console.WriteLine(necklace[i].name + " " + necklace[i].price + " $");
			}
		}

		public void Find()
		{
			bool flag = false;
			Console.WriteLine();
			Console.WriteLine("Введіть діапазон прозорості: ");
			string diapasone = Console.ReadLine();
			for (int i = 0; i < necklace.Count; i++)
			{
				if (diapasone == necklace[i].transparency)
				{
					Console.WriteLine("Result: " + necklace[i].name);
					flag = true;
				}
			}
			if (flag == false)
			{
				Console.WriteLine("Введено неправильні дані!");
			}

		}
		public void ShowList()
		{
			foreach (Stone aPart in necklace)
			{
				Console.WriteLine(aPart);
			}
			Console.WriteLine("------------------");
		}
	}
}
