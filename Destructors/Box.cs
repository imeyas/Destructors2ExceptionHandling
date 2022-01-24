using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    public class Box

        //Overloading an operator using a Box's parameters as an example to get the sum of the Height and Width of two boxes to create a third box
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Box (int h, int w)
        {
            Height = h;
            Width = w;
        }

        public static Box operator+(Box box1, Box box2) //This line applies the overloading "operator" keyword with the symbol of the operator (in this case, +)
        {
            int h = box1.Height + box2.Height;
            int w = box1.Width + box2.Width;
            var result = new Box(h, w);
            return result;
        }
    }
}
