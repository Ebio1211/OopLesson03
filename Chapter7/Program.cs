using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {

            //7-1
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text); //問題7.1.1
        }

        static void Exercise1_1(string text)
        {
            //var dict = new Dictionary<char, int>();
            var dict = new SortedDictionary<char, int>();
            foreach (var ch in text)
            {
                char upc = char.ToUpper(ch);
                if ('A'<= upc && upc <= 'Z')
                {
                    if (dict.ContainsKey(upc))
                    {
                        //登録済み
                        dict[upc]++;
                    }
                    else
                    {
                        //未登録
                        dict[upc] = 1;
                    }
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            
        }
    }
}
