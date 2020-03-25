using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    class square
    {
        static int doSquare(int x) {
            int lenInput = x.ToString().Length;
            int calSquare = x * x;
            int lenSquare = calSquare.ToString().Length;
            int lastLenSquare = Convert.ToInt32(calSquare.ToString().Substring(lenSquare - lenInput, lenInput));
            if (lastLenSquare == x)
            {
                return 1;
            }
            else {
                return 0;
            }


        }
        static void Main(string[] args)
        {
            int result = doSquare(9);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
