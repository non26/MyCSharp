using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer
{
    class createPointer
    {
        public static unsafe void test_pointer()
        {
            int var = 20;
            int* p = &var;

            Console.WriteLine("Data is: {0} ", var); // show the value that 'var' store
            Console.WriteLine("Address is: {0}", (int)p); // show the address of what pointer pointing to
            Console.WriteLine("Data is: {0} ", *p); // show the value of the address where pointer pointing to 
            Console.ReadKey();
        }
    }
}
