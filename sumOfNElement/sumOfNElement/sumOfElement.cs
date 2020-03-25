using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfNElement
{
    class sumOfElement
    {
        static int sumNElement(int k, int[] array1) {
            int lenArray = array1.Length;
            int numberOFNElement = 1;
            for (int round = 0; round < lenArray - 1; round++) {
                int total = 0;
                for (int number = 1; number<= numberOFNElement; number++) {
                    int element = array1[lenArray - number];
                    total += element;
                }
                if (total == k) {
                    return 1;
                }
                else {
                    numberOFNElement += 1;
                    continue;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int result = sumOfElement.sumNElement(5, new int[] { 1,2,3,45,-40,1});
            Console.WriteLine(result);
        }
    }
}
