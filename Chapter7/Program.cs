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

            //7-1
            //var lines = new Dictionary<int, List<string>>() { };
            //string line = "Cozy lummox gives smart squid who asks for job pen";
            //Console.WriteLine("---7.1.1---");
            //int i = 0;
            //foreach (var item in line)
            //{
            //    var key = i++;
            //    var value = line.Skip(i).Take(1);
            //    lines[key] = new List<string> { value.ToString() };

            //}
            

        }
        static public void DuplicateKey()
        {
            Console.WriteLine("********************");
            Console.WriteLine("*辞書登録プログラム*");
            Console.WriteLine("********************");
            var dict = new Dictionary<string, List<string>>() { };
            string selectdict;
            bool strer;

            do
            {
                Console.WriteLine("1. 登録　2. 内容を表示　3. 終了");
                Console.Write("\n>");
                selectdict = Console.ReadLine();
                do
                {
                    if (selectdict =="1"|| selectdict=="2"||selectdict=="3")
                    {
                        strer = true;
                    }
                    else
                    {
                        strer = false;
                        Console.WriteLine("1. 登録　2. 内容を表示　3. 終了");
                        Console.Write(">");
                        selectdict = Console.ReadLine();
                    }
                } while (strer == false);
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
