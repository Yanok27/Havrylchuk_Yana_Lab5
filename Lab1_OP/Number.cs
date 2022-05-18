using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_OP
{
    public class Number
    {
        public int FirstNumber { get; private set; }
        public int SecondNumber { get; private set; }

        public Number(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public void SetNumber(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public void Show()
        {
            Console.WriteLine($"First number: {FirstNumber}\nSecond number: {SecondNumber}");
        }

        public int Sum()
        {
            return FirstNumber + SecondNumber;
        }

        public int FindMax()
        {
            if (FirstNumber > SecondNumber)
            {
                return FirstNumber;
            }

            return SecondNumber;
        }
    }
}

