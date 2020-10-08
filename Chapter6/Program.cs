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
            var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, 8, -1, 6, 4, };
            Console.WriteLine($"平均値：{numbers.Average()}");
            Console.WriteLine($"合計値：{numbers.Sum()}");
            Console.WriteLine($"最小値：{numbers.Where(n=>n>0).Min()}");
            Console.WriteLine($"最大値：{numbers.Max()}");

            bool exists = numbers.Any(n => n % 7 == 0);


            var results = numbers.Where(n => n > 0).Take(5);

            foreach (var result in results)
            {
                Console.Write(result + " ");
            }



            Console.WriteLine("\n--------------------------");
            var books = Books.GetBooks();
            Console.WriteLine($"本の平均価格：{Math.Round(books.Average(s => s.Price),1)}円");
            Console.WriteLine($"本の合計価格：{books.Sum(s => s.Price)}円");
            Console.WriteLine($"本のページが最大：{books.Max(s => s.Pages)}ページ");
            Console.WriteLine($"高価な本：{books.Max(s => s.Price)}円");
            Console.WriteLine($"タイトルに「物語」がある冊数：{books.Count(n=>n.Title.Contains("物語"))}");

            //600ページを超える書籍があるか？
            Console.Write("\n600ページを超える書籍は");
            Console.WriteLine(books.Any(n => n.Pages > 600) ? "ある" : "ない");

            //すべてが200ページ以上の書籍化？(All)
            Console.Write("\nすべて200ページ以上");
            Console.WriteLine(books.All(n => n.Pages >= 200) ? "ある" : "ない");

            //400ページを超える本は何冊目か？(FirstOrDefault)
            //var number = books.FirstOrDefault(n => n.Pages > 400);
            //int count;
            //for (count = 0; count < books.Count; count++)
            //{
            //    if (books[count].Pages == number.Pages)
            //        break;
            //}
            var count = books.FindIndex(n => n.Pages > 400);
            Console.WriteLine($"\n400ページを超える書籍は{count + 1}冊目にある");

            //本の値段が400円以上のものを3冊表示
            var book = books.Where(n => n.Price >= 400).Take(3);
            Console.WriteLine("\n本の値段が400円以上の書籍");
            foreach (var n in book)
            {
                Console.WriteLine(n.Title + " ");
            }






        }
    }
}
