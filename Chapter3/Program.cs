using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region リスト
            var numbers = new List<int>
            {
                12,87,94,14,53,20,40,35,76,91,31,17,48,
            };

            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };
            #endregion

            //3-1-1
            Console.WriteLine("\n----3.1.1----");
            var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);

            if (exists == true)
            {
                Console.WriteLine("8または9で割り切れる数は存在する");
            }
            else
            {
                Console.WriteLine("8または9で割り切れる数は存在しない");
            }
            Console.WriteLine();

            //3-1-2
            Console.WriteLine("\n----3.1.2----");
            numbers.ForEach(s => Console.WriteLine(s / 2.0));

            //3-1-3
            Console.WriteLine("\n----3.1.3----");
            numbers.Where(s => s >= 50).ToList().ForEach(s=> Console.WriteLine(s));

            //3-1-4
            Console.WriteLine("\n----3.1.4----");　
            numbers.Select(s => s * 2).ToList().ForEach(s=> Console.WriteLine(s));

            //3-2-1
            Console.WriteLine("\n----3.2.1----");
            do
            {
                Console.Write("都市名を入力(空行で終了)：");
                var line = Console.ReadLine();
                //lineが空白だったらbreak
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }
                var city = names.FindIndex(s => s == line);
                if (city != -1)
                {
                    Console.WriteLine($"項番{city}にあります\n");
                }
                else 
                {
                    Console.WriteLine($"{city} 存在しません\n");
                }
            } while (true);

            //3-2-2
            Console.WriteLine("\n----3.2.2----");
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);

            //3-2-3
            Console.WriteLine("\n----3.2.3----");
            var selected = names.Where(s => s.Contains('o')).ToArray();
            foreach (var name in selected)
            {
                Console.WriteLine(name);
            }

            //3-2-4
            Console.WriteLine("\n----3.2.4----");
            names.Where(s => s.StartsWith("B")).Select(s => s.Length).ToList().
                                             ForEach(s=>Console.WriteLine(s));

        }
    }
}
