using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterMethod
{
    class test_ByVal{
        public static void byVal(int x, int[] y) {
            x = 3;
            Console.WriteLine(x.ToString());
            Console.WriteLine("Before changing an array");
            foreach (int item in y)
            {
                Console.Write(item.ToString() + " ");
            }
            y[0] = 6;
            Console.WriteLine("After changing an array");
            foreach (int item in y) {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}
