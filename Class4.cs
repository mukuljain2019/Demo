using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class4
    {
        public int method()
        {
            return (2);
            Console.WriteLine("I am in method1");
        }
        public static void main()
        {
            int res;
            Class4 ob = new Class4();
            res = ob.method();
            Console.WriteLine("res="+res);
        }
    }
}
