using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    public class Clients
    {
        //Applying the use of an index within a class along with the "this" keyword
        private string[] names = new string[10];
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        
        public Clients()
        {

        }
    }
}
