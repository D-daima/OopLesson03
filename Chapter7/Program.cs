using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter7 {
    class Program {
        static void Main(string[] args) {
            ast();
            Console.WriteLine("* 辞書登録プログラム *");
            ast();
            var dict = new Dictionary<string, List<string>>();
            do {
                Console.WriteLine($"1.登録　2.表示　3.終了");
                try {
                    Console.Write('>');
                    int select = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if(select == 1) {

                        Console.Write("KEYを入力：");
                        var key = Console.ReadLine();
                        Console.Write("VALUEを入力：");
                        var value = Console.ReadLine();

                        if(dict.ContainsKey(key)) {
                            dict[key].Add(value);
                        } else {
                            dict[key] = new List<string> { value };
                        }
                        Console.WriteLine("登録しました!");
                    } else if(select == 2) {
                        if(dict.Count == 0)
                            Console.WriteLine("ディクショナリは空です。");
                        else
                            foreach(var item in dict) {
                                foreach(var term in item.Value) {
                                    Console.WriteLine("{0}:{1}", item.Key, term);
                                }
                            } 
                    } else if(select == 3) {
                        break;
                    } else {
                        Console.WriteLine("1,2,3を選択してください!");
                    }
                } catch(Exception) {
                    Console.WriteLine("数字1,2,3を入力してください!");
                }    
            } while(true);
        }
       
        static public void ast () {
            int n = 22;
            for(int i = 0; i < n; i++) {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}
