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
            DuplicateKey();



        }
        static public void DuplicateKey()
        {
            Console.WriteLine("********************");
            Console.WriteLine("*辞書登録プログラム*");
            Console.WriteLine("********************");
            var dict = new Dictionary<string, List<string>>() { };
            string selectdict;

            do
            {
                Console.Write("\n1. 登録　2. 内容を表示　3. 終了");
                Console.Write("\n>");
                selectdict = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(selectdict))
                {
                    Console.Write(">");
                    selectdict = Console.ReadLine();
                }
                if (selectdict == "1")
                {
                    Console.Write("\nKeyを入力：");
                    var key = Console.ReadLine();
                    Console.Write("valueを入力：");
                    var value = Console.ReadLine();
                    if (dict.ContainsKey(key))
                    {
                        dict[key].Add(value);
                    }
                    else
                    {
                        dict[key] = new List<string> { value };
                    }

                    Console.Write("登録しました！\n");
                }
                if (selectdict == "2")
                {
                    Console.WriteLine();
                    foreach (var item in dict)
                    {
                        foreach (var term in item.Value)
                        {
                            Console.WriteLine("{0} : {1}", item.Key, term);
                        }
                    }
                }
                if (selectdict == "3")
                {
                    Console.WriteLine("\nプログラムを終了します");
                    break;
                }
            } while (selectdict == "1" || selectdict == "2");

            

        }
    }
}
