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

            //整数の例
            var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24 };
            //var strings = numbers.Distinct().ToArray();
            //foreach(var str in strings) {
            //    Console.Write(str + " ");
            //}
            numbers.Select(n => n.ToString("0000")).Distinct().ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine("\n\n---------------");

            var sortedNumbers = numbers.OrderBy(n => n).Distinct();
            foreach(var nums in sortedNumbers) {
                Console.Write(nums + " ");
            }
            Console.WriteLine("\n\n---------------");

            //文字列の例
            var words = new List<string>{
                "Microsoft","Apple","Google","Oracle","Facebook",};
            var lower = words.Select(name => name.ToLower()).ToArray();
            //オブジェクトの例
            var books = Books.GetBooks();
            //タイトルリスト
            var titles = books.Select(x => x.Title);
            foreach(var title in titles) {
                Console.Write(title + " ");
            }
            Console.WriteLine("\n\n---------------");
            //ページ数の多い順に並べ替え（または金額の高い順）
            var sortedPages = books.OrderByDescending(x => x.Pages).Take(3);
            foreach(var sortedPage in sortedPages) {
                Console.WriteLine($"{sortedPage.Title} : {sortedPage.Pages}ページ");
            }
        }
    }
}
