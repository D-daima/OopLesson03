using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) {
            for(int i = 0; i < 5; i++) {
                var array = new YearMonth[5];
                array[i] = new YearMonth(2001, 8);
            }
            
        }
    }
}
