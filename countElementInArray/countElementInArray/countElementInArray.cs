using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countElementInArray
{
    class countElementInArray
    {
        public static int countElement(int[] arr) {
            int lenArr = arr.Length;
            var distinctArray = arr.Distinct(); // get distinct elements
            foreach (int element in distinctArray) {
                int countElement = arr.Count(item => (item==element));
                if (countElement == 2){
                }else {
                    return 0;
                }
                }
            return 1;
            }
        static void Main(){
            int result = countElementInArray.countElement(new int[] { 1, 2, 3, 3, 2, 1 ,4});
            Console.WriteLine(result);
            Console.ReadKey();
            
        }
    }
}
