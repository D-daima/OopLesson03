using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            //6.1.1
            Console.WriteLine($"最大値：{numbers.Max()}");
            Console.WriteLine("\n------------");
            //6.1.2
            numbers.Reverse().Take(2).Reverse().ToList().ForEach(s=>Console.Write(s + " "));
            Console.WriteLine("\n\n------------");
            //6.1.3
            foreach(var number in numbers) {
                Console.Write(number.ToString() + " ");
            }
            Console.WriteLine("\n\n------------");

            //6.1.4
            var line = numbers.OrderBy(n => n).Take(3);
            foreach(var item in line) {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\n------------");

            //6.1.5
            numbers.Distinct().Where(n => n > 10).ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine("\n\n------------");
        }
    }
}
