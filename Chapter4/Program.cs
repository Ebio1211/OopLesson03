using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4-2-1
            var yearmonth = new YearMonth[]
            {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,12),
                new YearMonth(2005,6),
                new YearMonth(2016,5)
            };

            //4-2-2
            Console.WriteLine("--4.2.2--");
            Exercise2_2(yearmonth);
            Console.WriteLine("------------");

            //4-2-4
            Console.WriteLine("--4.2.4--");
            Exercise2_4(yearmonth);
            Console.WriteLine("------------");

            //4-2-5
            Console.WriteLine("--4.2.5--");
            Exercise2_5(yearmonth);

        }
        private static void Exercise2_2(YearMonth[] ymCollection)
        {
            foreach (var ym in ymCollection)
            {
                Console.WriteLine(ym);
            }
        }

        //4-2-3
        static YearMonth FindFirst21C(YearMonth[] yms)
        {
            foreach (var ym in yms)
            {
                if (ym.Is21Century)
                    return ym;
            }
            return null;
        }
        //4-2-4
        private static void Exercise2_4(YearMonth[] ymCollection)
        {
            var yearmonth = FindFirst21C(ymCollection);

            var s = yearmonth == null ? "21世紀のデータは存在しません" : yearmonth.ToString();
            Console.WriteLine(s);
        }
        //4-2-5
        private static void Exercise2_5(YearMonth[] ymCollection)
        {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array)
            {
                Console.WriteLine(ym);
            }
        }


    }
}
