using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createArray
{
    class changeElement
    {
        public static void change() {
            int[] testChange = new int[] { 1, 2, 3 };
            Console.WriteLine("Before changing");
            foreach (int item in testChange) {
                Console.Write(item.ToString() + " ");
            }
            testChange[0] = 6;
            Console.WriteLine();
            Console.WriteLine("After changing");
            foreach (int item in testChange)
            {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}
