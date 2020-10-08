using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数の例
            var numbers = new List<int> { 12, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24 };

            var strings = numbers.Distinct().ToArray();
            foreach (var str in strings)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            numbers.Distinct().Select(n => n.ToString("0000")).ToList().ForEach(s => Console.Write(s + " "));

            //並べ替え
            Console.WriteLine();
            numbers.Distinct().OrderBy(n => n).ToList().ForEach(s => Console.Write(s + " "));

            //文字列の例
            Console.WriteLine("\n\n--------------------");
            var words = new List<string> {
                "Microsoft","Apple","Google","Oracle","Facebook",};

            var lower = words.Select(name => name.ToLower()).ToArray();

            //オブジェクトの例
            Console.WriteLine("\n\n--------------------");
            var books = Books.GetBooks();
            //タイトルリストのみのリスト
            var titles = books.Select(n => n.Title);
            foreach (var title in titles)
            {
                Console.Write(title + " ");
            }

            //ページ数の多い順に並べ替え（または金額の高い順）
            Console.WriteLine("\n\n--------------------");
            books.OrderByDescending(n => n.Pages).Take(3).ToList().ForEach(s=> Console.WriteLine(s.Title + " "+s.Pages));


        }
    }
}
