using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            string longline = "Jackdaws love my big sphinx of quartz";
            var lines = "Novelist=谷崎潤一郎；BestWork=春琴抄；Born=1886";
            # region 5-1
            //Console.WriteLine("--5.1--");
            //Console.Write("文字を入力してください：");
            //string str1 = Console.ReadLine();
            //Console.Write("文字を入力してください：");
            //string str2 = Console.ReadLine();
            //if (String.Compare(str1, str2, ignoreCase: true) == 0)
            //{
            //    Console.WriteLine("一致している。");
            //}
            //else
            //{
            //    Console.WriteLine("一致していない。");
            //}
            //Console.WriteLine("-------------\n");
            #endregion
            #region 5-2
            //Console.WriteLine("--5.2--");
            //Console.Write("数値文字列：");
            //string line = Console.ReadLine();
            //if (int.TryParse(line, out var num))
            //{
            //    Console.WriteLine($"{num:#,#}");
            //}
            //else
            //{
            //    Console.WriteLine("数値文字列ではありません");
            //}
            //Console.WriteLine("-------------\n");
            #endregion
            #region 5-3
            #region 5-3-1
            Console.WriteLine("--5.3.1--");
            var count = longline.Count(s => s.ToString() == " ");
            Console.WriteLine("空白数：{0}",count);
            Console.WriteLine("-------------\n");
            #endregion
            #region 5-3-2
            Console.WriteLine("--5.3.2--");
            var replaced = longline.Replace("big", "small");
            Console.WriteLine(replaced);
            Console.WriteLine("-------------\n");
            #endregion
            #region 5-3-3
            Console.WriteLine("--5.3.3--");
            var text = longline.Split(' ').Count();
            //var text = longline.Split(' ').Length();
            Console.WriteLine("単語数：{0}", text);
            Console.WriteLine("-------------\n");
            #endregion
            #region 5-3-4
            Console.WriteLine("--5.3.4--");
            longline.Split(' ').Where(s=> s.Length <= 4)
                .ToList().ForEach(Console.WriteLine);
            Console.WriteLine("-------------\n");
            #endregion
            #region 5-3-5
            Console.WriteLine("--5.3.5--");
            string[] array  = longline.Split(' ').ToArray();
            if (array.Length >=0)
            {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1))
                {
                    sb.Append(' ');
                    sb.Append(word);
                }
                Console.WriteLine(sb);
            }
            Console.WriteLine("-------------\n");
            #endregion
            #endregion

            #region 5-4
            Console.WriteLine("--5.4--");
            foreach (var item in lines.Split('；'))
            {
                var word = item.Split('=');
                Console.WriteLine("{0}:{1}", ToJapanese(word[0]), word[1]);
            }
            Console.WriteLine("-------------\n");
            #endregion
        }
        static string ToJapanese(string key)
        {
            switch (key)
            {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "    ";
            }
        }
    }
}
