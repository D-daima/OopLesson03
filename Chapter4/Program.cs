using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) {
            //4.2.1
            var yearMonths = new YearMonth[] {
               new YearMonth(1980,1),
               new YearMonth(1990,1),
               new YearMonth(2000,1),
               new YearMonth(2010,1),
               new YearMonth(2020,1),
           };
            //4.2.2
            foreach(var item in yearMonths) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            //4.2.3
            Console.WriteLine(FindFirst21C(yearMonths));
            Console.WriteLine("--------------");

            //4.2.4
            Ex2_4(yearMonths);
            Console.WriteLine("--------------");

            //4.2.5
            Ex2_5(yearMonths);
            Console.WriteLine("--------------");
        }

        //4.2.3のメソッド
        static YearMonth FindFirst21C(YearMonth[] yearMonths) {
            foreach(var item in yearMonths) {
                if(2001 <= item.Year && item.Year <= 2100) {
                    return item;
                }
            }
            return null;
        }

        private static void Ex2_4(YearMonth[] yms) {
            var yearmonth = FindFirst21C(yms);
            var s = yearmonth == null ? "21世紀のデータはありません" : yearmonth.ToString();
            Console.WriteLine(s);
        }

        private static void Ex2_5(YearMonth[] yms) {
            var array = yms.Select(s => s.AddMonth()).ToArray();
            foreach(var item in array) {
                Console.WriteLine(item);
            }
        }
    }
}
