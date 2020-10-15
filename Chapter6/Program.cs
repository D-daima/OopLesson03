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
            #region 6.1
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            //6.1.1
            Console.WriteLine("問題6.1.1");
            Console.WriteLine($"最大値：{numbers.Max()}");
            Console.WriteLine("\n------------");
            //6.1.2
            //numbers.Reverse().Take(2).Reverse().ToList().ForEach(s=>Console.Write(s + " "));
            Console.WriteLine("問題6.1.2");
            int pos = numbers.Length - 2;
            foreach(var num in numbers.Skip(pos)) {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n\n------------");
            //6.1.3
            Console.WriteLine("問題6.1.3");
            numbers.Select(n => n.ToString()).ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine("\n\n------------");

            //6.1.4
            Console.WriteLine("問題6.1.4");
            foreach(var item in numbers.OrderBy(n => n).Take(3)) {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\n------------");

            //6.1.5
            Console.WriteLine("問題6.1.5");
            Console.WriteLine(numbers.Distinct().Count(n => n > 10));
            Console.WriteLine("\n\n------------");
            #endregion

            #region 6.2
            var books = new List<Book> {
                new Book { Title = "C#プログラミングの新常識「C#」", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            ////6.2.1
            //Console.WriteLine("問題6.2.1");
            //var book = books.FirstOrDefault(x => x.Title == "ワンダフル・C#ライフ");
            //if(book != null) {
            //    Console.WriteLine($"{book.Price}円:{book.Pages}ページ");
            //}
            //Console.WriteLine("\n------------");

            ////6.2.2
            //Console.WriteLine("問題6.2.2");
            //int count = books.Count(x => x.Title.Contains("C#"));
            //Console.WriteLine($"{count}冊");
            //Console.WriteLine("\n------------");

            ////6.2.3
            //Console.WriteLine("問題6.2.3");
            //var avg = books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages);
            //Console.WriteLine($"タイトルにC#が含まれる書籍の平均ページ：{avg}ページ");
            //Console.WriteLine("\n------------");

            ////6.2.4
            //Console.WriteLine("問題6.2.4");
            //var obj =  books.FirstOrDefault(x => x.Price >= 4000);
            //if(obj != null) {
            //    Console.WriteLine($"タイトル：{obj.Title}");
            //}           
            //Console.WriteLine("\n------------");

            ////6.2.5
            //Console.WriteLine("問題6.2.5");
            //var pages = books.Where(x => x.Price < 4000).Max(x => x.Pages);
            //Console.WriteLine($"最大{pages}ページ");
            //Console.WriteLine("\n------------");

            ////6.2.6
            //Console.WriteLine("問題6.2.6");
            //var odPrices = books.Where(x => x.Pages >= 400).OrderByDescending(x => x.Price);
            //foreach(var odPrice in odPrices) {
            //    Console.WriteLine($"タイトル：{odPrice.Title}");
            //    Console.WriteLine($"価格：{odPrice.Price}");
            //}
            //Console.WriteLine("\n------------");

            ////6.2.7
            //Console.WriteLine("問題6.2.7");
            //var selected = books.Where(x => x.Title.Contains("C#") && x.Pages <= 500);
            //foreach(var select in selected) {
            //    Console.WriteLine($"タイトル：{select.Title}");
            //}
            #endregion

            //すべての書籍から「C#」の文字がいくつあるかをカウントする
            int count = 0;
            foreach(var book in books) {
                for(int i = 0; i < book.Title.Length - 1; i++) {
                    if((book.Title[i] == 'C') && (book.Title[i + 1] == '#'))
                        count++;
                }                
            }
            Console.WriteLine($"文字列「C#」の個数は{count}です。");
        }
    }
}