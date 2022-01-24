using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    public class Cat
    {
        public static int count = 0;

        public Cat()
        {
            count++;

            Console.WriteLine(Cat.count);
        }
    }
}
