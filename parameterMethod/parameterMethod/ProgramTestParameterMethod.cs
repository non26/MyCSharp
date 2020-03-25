using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterMethod
{
    class ProgramTestParameterMethod
    {
        static void Main(string[] args)
        {
            ProgramTestParameterMethod test = new ProgramTestParameterMethod();
            test.call_test_ByVal();
            Console.WriteLine();
            test.call_test_ByRef();
            Console.WriteLine();
            test.call_test_out();
            Console.ReadKey();
        }
        void call_test_ByVal() {
            int ar1 = 2;
            int[] ar2 = new int[] { 1, 2, 3 };
            int[] ar3 = new int[ar2.Length] ;
            //Array.Copy(ar2, ar3, ar2.Length);
            //test_ByVal.byVal(ar1, ar3);
            test_ByVal.byVal(ar1, ar2);
            Console.WriteLine(Environment.NewLine + "After chenging the value in test_ByVal class");
            foreach (int item in ar2)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine(ar1);

        }
        void call_test_ByRef() {
            int ar1 = 2;
            int[] ar2 = new int[] { 4,5,6 };
            int[] ar3 = new int[ar2.Length];
            //Array.Copy(ar2, ar3, ar2.Length);
            //test_ref.byRe(ref ar1, ref ar3);
            test_ref.byRe(ref ar1, ref ar2);
            Console.WriteLine(Environment.NewLine + "After chenging the value in test_refclass");
            foreach (int item in ar2)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine(ar1);
        }
        void call_test_out() {
            int ar1 = 100;
            test_out.byOut(ar1, out int a);
            Console.WriteLine(a);
            
        }
    }
}
