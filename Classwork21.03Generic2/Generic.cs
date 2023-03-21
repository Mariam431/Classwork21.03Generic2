using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork21._03Generic2
{
    internal class Generic<T>
    {
        public void Meth1(T t)
        {
            T k = t;
            Console.WriteLine(k);
        }
        public void Meth2(T t, bool a=true)
        {
            if (a)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("no");
        }
    }
}
            