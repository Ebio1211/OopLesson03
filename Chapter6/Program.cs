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
            var numbers = new int[] { 5,10,17,9,3,21,10,40,21,3,35 };

            //6-1-1
            Console.WriteLine("---6.1.1---");
            Console.WriteLine($"最大値：{numbers.Max()}");

            //6-1-2
            Console.WriteLine("\n---6.1.2---");
            //var nums = numbers.Reverse().Take(2);
            //foreach (var num in nums)
            //{
            //    Console.Write(num + " ");
            //}
            int pos = numbers.Length - 2;
            foreach (var number in numbers.Skip(pos))
            {
                Console.Write(number + " ");
            }


            //6-1-3
            Console.WriteLine("\n---6.1.3---");
            numbers.Select(n => n.ToString()).ToList().ForEach(s => Console.Write(s + " "));

            //6-1-4
            Console.WriteLine("\n---6.1.4---");
            numbers.OrderBy(n => n).Take(3).ToList().ForEach(s => Console.Write(s + " "));

            //6-1-5
            Console.WriteLine("\n---6.1.5---");
            var count = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine(count);

            //6-2
            Console.WriteLine("\n----------6.2-------------");
            var books = new List<Book> {
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            //6-2-1
            Console.WriteLine("\n---6.2.1---");
            var book = books.Where(s => s.Title == "ワンダフル・C#ライフ");
            foreach (var s in book)
            {
                Console.WriteLine($"価格：{s.Price}　ページ数：{s.Pages}");
            }

            //6-2-2
            Console.WriteLine("\n---6.2.2---");
            Console.WriteLine($"タイトルに「C#」を含む書籍の冊数：{books.Count(s=>s.Title.Contains("C#"))}");

            //6-2-3
            Console.WriteLine("\n---6.2.3---");
            Console.WriteLine($"タイトルに「C#」を含む書籍の平均ページ数：" +
                                $"{books.Where(s=>s.Title.Contains("C#")).Average(s=>s.Pages)}");

            //6-2-4
            Console.WriteLine("\n---6.2.4---");
            Console.WriteLine(books.FirstOrDefault(s => s.Price >= 4000).Title);

            //6-2-5
            Console.WriteLine("\n---6.2.5---");
            Console.WriteLine($"{books.Where(s => s.Price < 4000).Max(s => s.Pages)}ページ");

            //6-2-6
            Console.WriteLine("\n---6.2.6---");
            books.Where(s => s.Pages >= 400).OrderByDescending(s => s.Price)
                .ToList().ForEach(s=>Console.WriteLine($"タイトル：{s.Title} 価格：{s.Price}"));

            //6-2-7
            Console.WriteLine("\n---6.2.7---");
            books.Where(s => s.Title.Contains("C#") && s.Pages <= 500).ToList().ForEach(s => Console.WriteLine(s.Title));


        }
    }
}
