using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // flatten
            var xs = new int[][] {new int[] {1,2}, new int[] {3,4}, new int[] {5,6}};
            xs.SelectMany(x => x).Print();

            // filter
            var ys = new int[]{700, 14, 45, 7000, 6, 49, 4, 2000, 400, 2012, 1999, 1997};
            ys.Where(i => i%7==0).Where(i => i>42).Print();

            // leap year
            ys.Where(i => (i>1582) && ((i%4==0 && i%100!=0) || (i%400==0))).Print();
            
        }
    }
}
