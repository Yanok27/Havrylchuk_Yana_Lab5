using System;

namespace Laba1_OP
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Number(10, 15);

            number.Show();
            int sum = number.Sum();
            int maxNumber = number.FindMax();

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Max number: " + maxNumber);
            Console.WriteLine("Serialize object...");
            NumberSerialization.Serialize(number);

            Console.WriteLine("|||||||||||||");
            Console.WriteLine("Changed number");

            number.SetNumber(-5, 10);
            number.Show();
            sum = number.Sum();
            Console.WriteLine("Sum: " + sum);

            Console.WriteLine("Deserialize...");
            Number oldNumber = NumberSerialization.Deserialize("/Users/User/source/repos/Laba1_OP/number.json");
            oldNumber.Show();
            oldNumber.Sum();
            oldNumber.FindMax();
        }
    }
}
