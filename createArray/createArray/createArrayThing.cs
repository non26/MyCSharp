using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createArray
{ 
    class createArrayThing
    {
        public static void createArray()
        {
            // without fix size of array
            int[] array1 = new int[] { 1 };
            foreach (int item in array1)
            {
                Console.Write(item.ToString() + " ");
            }
            // fix size of array
            Console.WriteLine();
            int[] array2 = new int[2] { 2, 2 };
            foreach (int item in array2)
            {
                Console.Write(item.ToString() + " ");
            }
            // this line of code is error because we fix the size of array by 3
            // but instantiate it with empty array
            //int[] array3 = new int[3] { };
            Console.WriteLine();
            int[] array3 = new int[3];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = 3;
            }
            foreach (int item in array3)
            {
                Console.Write(item.ToString() + " ");
            }
        }
        public static void createArray1() {
            int[] Test = new int[2];
            Test[0] = 99;
            Test[1] = 99;
            foreach (int item in Test) {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
