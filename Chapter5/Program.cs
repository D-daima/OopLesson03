using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5 {
    class Program {
        static void Main(string[] args) {
            //5.1
            Console.Write("文字列入力：");
            var Fstr = Console.ReadLine();
            Console.Write("文字列入力：");
            var Lstr = Console.ReadLine();

            if(String.Compare(Fstr, Lstr,ignoreCase:true) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }

            Console.WriteLine("----------");

            //5.2
            Console.WriteLine("数値入力：");
            var line = Console.ReadLine();
            int num;
            if(int.TryParse(line, out num)) {
                Console.WriteLine($"{num:#,#}");
                var numStr = num.ToString("#,#");
                Console.WriteLine(numStr);
            } else {
                Console.WriteLine("数値文字列ではありません");
            }

            //5.3.1
            var Ex5_3 = "Jackdaws love my big sphinx of quartz";
            Console.WriteLine($"{Ex5_3.Count()}文字");
            Console.WriteLine("------------");

            //5.3.2
            var replace = Ex5_3.Replace("big", "small");
            Console.WriteLine(replace);
            Console.WriteLine("------------");

            //5.3.3
            string[] words = Ex5_3.Split(' ');
            Console.WriteLine($"{words.Length}単語");
            Console.WriteLine("------------");

            //5.3.4
            words.Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("------------");

            //5.3.5
            var sb = new StringBuilder();
            foreach(var word in words) {
                sb.Append(word);
            }
            var text = sb.ToString();
            Console.WriteLine(text);
            
        }
    }
}
