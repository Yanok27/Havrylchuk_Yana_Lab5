using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_OP
{
    public class NumberSerialization
    {
        public static void Serialize(Number number)
        {
            string objectToSerialize = JsonSerializer.Serialize(number);
            File.WriteAllText("/Users/User/source/repos/Laba1_OP/number.json", objectToSerialize);
        }

        public static Number Deserialize(string path)
        {
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Number>(json);
        }
    }
}
 