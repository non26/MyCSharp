using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterMethod
{
    class test_out
    {
        public static void byOut(int x, out int a) {
            x++;
            a = x;
        }
    }
}
