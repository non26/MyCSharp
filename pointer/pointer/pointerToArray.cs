using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer
{
    class pointerToArray
    {
        static unsafe void test_pointerArray(string[] args)
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)
                //int* ptr = list; this error.
                /* let us have array address in pointer */
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(*ptr);
                    Console.WriteLine(ptr); //error
                    Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
                }
            //Console.WriteLine(*ptr); // why error?
        }
    }
}
