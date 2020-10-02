﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class YearMonth
    {
        //4.1.1
        //プロパティ(2つ)
        public int Year { get; private set; } //年
        public int Month { get; private set; }//月
        //コンストラクタ
        public YearMonth(int year, int month)
        {
            Year = year;
            Year = month;
        }

        //4.1.2
        //Is21Centuryプロパティを追加
        public bool Is21Century
        {
            get
            {
                return 2001 <= Year && Year <= 2100;
            }
        }

        //4.1.3
        //AddOneMonth()メソッドを追加
        public YearMonth AddOneMonth()
        {
            if (12 == this.Month)
            {
                return new YearMonth(this.Year++, this.Month = 1);
            }
            else
            {
                return new YearMonth(this.Year, this.Month++);
            }
        }


        //4.1.4
        //ToString()メソッドのオーバーライド
        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }
    }
}