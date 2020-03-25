using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class createClass {
        public void printHello() {
            Console.WriteLine("Hello world");
        }
    }
    class testHelloWorld
    {
        static void Main(string[] args)
        {
            createClass testInstance = new createClass();
            testInstance.printHello();
            Console.ReadKey();
        }
    }
}
