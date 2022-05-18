using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, string[]>()
            {
                [1] = new string[2] { "A", "B" },
                [2] = new string[2] { "C", "c" },
                [3] = new string[3] { "F", "D", "L" },
                [4] = new string[4] { "k", "b", "y", "j" }
            };
            for (int i = 1; i <= dict.Count; i++)
            {
                for (int j = i + 1; j <= dict.Count; j++)
                {
                    string res = "";
                    foreach (string c in dict[i])
                    {
                        foreach (string a in dict[j])
                        {
                            res += c + a;
                        }
                        res += " ";

                    }
                    Console.WriteLine(res);
                    /*string str = JsonConvert.SerializeObject(res);
                    File.AppendAllText("C:/Users/User/Downloads/Telegram Desktop/Lab3_2/Lab3_2/Data.json", str);*/

                }
            }
        }
    }
}
