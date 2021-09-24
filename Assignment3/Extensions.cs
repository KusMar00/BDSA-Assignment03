using System;
using System.Collections.Generic;

namespace Assignment3
{
    public static class Extensions
    {
        public static void Print<T>(this IEnumerable<T> items) {
            foreach(var item in items) {
                Console.WriteLine(item);
            } 
        }
    }
}
