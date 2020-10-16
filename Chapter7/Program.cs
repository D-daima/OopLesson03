using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter7 {
    class Program {
        static void Main(string[] args) {
            #region 辞書登録プログラム
            //ast();
            //Console.WriteLine("* 辞書登録プログラム *");
            //ast();
            //var dict = new Dictionary<string, List<string>>();
            //do {
            //    Console.WriteLine($"1.登録　2.表示　3.終了");
            //    try {
            //        Console.Write('>');
            //        int select = int.Parse(Console.ReadLine());
            //        Console.WriteLine();
            //        if(select == 1) {

            //            Console.Write("KEYを入力：");
            //            var key = Console.ReadLine();
            //            Console.Write("VALUEを入力：");
            //            var value = Console.ReadLine();

            //            if(dict.ContainsKey(key)) {
            //                dict[key].Add(value);
            //            } else {
            //                dict[key] = new List<string> { value };
            //            }
            //            Console.WriteLine("登録しました!");

            //        } else if(select == 2) {
            //            if(dict.Count == 0)
            //                Console.WriteLine("ディクショナリは空です。");
            //            else
            //                foreach(var item in dict) {
            //                    foreach(var term in item.Value) {
            //                        Console.WriteLine("{0}:{1}", item.Key, term);
            //                    }
            //                }

            //        } else if(select == 3) {
            //            break;
            //        } else {
            //            Console.WriteLine("1,2,3を選択してください!");

            //        }
            //    } catch(Exception) {
            //        Console.WriteLine();
            //        Console.WriteLine("数字1,2,3を入力してください!");

            //    }
            //    Console.WriteLine();
            //} while(true);
            #endregion
            //var text = "Cozy lummox gives smart squid who asks for job pen";
            //Exercise1_1(text);//問題7.1.1
            //Exercise1_2(text);//問題7.1.2

            var abbrs = new Abbreviations();

            //7.2.3
            int count = abbrs.Count;
            Console.WriteLine($"用語数：{count}");
            Console.WriteLine();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            // インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach(var name in names) {
                var fullname = abbrs[name];
                if(fullname == null)
                    Console.WriteLine("{0}は見つかりません", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();

            // ToAbbreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if(abbreviation == null)
                Console.WriteLine("{0} は見つかりません", japanese);
            else
                Console.WriteLine("「{0}」の略語は {1} です", japanese, abbreviation);
            Console.WriteLine();

            // FindAllメソッドの利用例
            foreach(var item in abbrs.FindAll("国際")) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();

            //7.2.3
            count = abbrs.Count;
            Console.WriteLine($"用語数：{count}");
            Console.WriteLine();

            if(abbrs.Remove(abbreviation)) {
                Console.WriteLine("削除成功");
            } else {
                Console.WriteLine("削除失敗");
            }

            //削除できているか確認
            count = abbrs.Count;
            Console.WriteLine($"用語数：{count}");
            Console.WriteLine();

            //7.2.4　三文字の省略語
            abbrs.Search();
        }
        #region 問題7.1
        //static void Exercise1_1(string text) {
        //    var dict = new Dictionary<char, int>();
        //    foreach(var ch in text) {
        //        Char upc = char.ToUpper(ch);
        //        if('A' <= upc && upc <= 'Z') {
        //            if(dict.ContainsKey(upc)) {
        //                dict[upc]++;
        //            } else {
        //                dict[upc] = 1;
        //            }
        //        }
        //    }
        //    foreach(var item in dict.OrderBy(x => x.Key)) {
        //        Console.WriteLine($"'{item.Key}':{item.Value}");
        //    }
        //}

        //static void Exercise1_2(string text) {
        //    var dict = new SortedDictionary<char, int>();
        //    foreach(var ch in text.ToUpper()) {
        //        if('A' <= ch && ch <= 'Z') {
        //            if(dict.ContainsKey(ch)) {
        //                dict[ch]++;
        //            } else {
        //                dict[ch] = 1;
        //            }
        //        }
        //    }
        //    foreach(var item in dict) {
        //        Console.WriteLine($"'{item.Key}': {item.Value}");
        //    }
        //}
        #endregion
        #region 辞書プロ*
        //static public void ast () {
        //    int n = 22;
        //    for(int i = 0; i < n; i++) {
        //        Console.Write('*');
        //    }
        //    Console.WriteLine();
        //}
        #endregion
    }
}
