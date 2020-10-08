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
            #region//5.1
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
            #endregion

            #region//5.2
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
            #endregion

            #region 5.3
            //5.3.1
            var text = "Jackdaws love my big sphinx of quartz";      
            Console.WriteLine($"空白{text.Count(c => c == ' ')}文字");
            Console.WriteLine("------------");

            //5.3.2
            var replace = text.Replace("big", "small");
            Console.WriteLine(replace);
            Console.WriteLine("------------");

            //5.3.3
            string[] words = text.Split(' ');
            //int n = text.Split(' ').Count()
            Console.WriteLine($"{words.Length}単語");
            Console.WriteLine("------------");

            //5.3.4
            words.Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("------------");
            

            //5.3.5
            if(words.Length > 0) {
                var sb = new StringBuilder(words[0]);
                foreach(var word in words.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                Console.WriteLine(sb.ToString());
            }
            Console.WriteLine("------------");
            #endregion

            //5.4
            var target = "Novelist=谷崎潤一郎;BestWork=春琴沙;Born=1886";            
            foreach(var item in target.Split(';')) {
                var wd = item.Split('=');
                Console.WriteLine("{0}:{1}", ToJapanese(wd[0]), wd[1]);
            }
        }
        static string ToJapanese(string key) {
            switch(key) {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "      ";
            }
        }
    }
}
