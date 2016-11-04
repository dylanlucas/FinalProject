using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    class Bag
    {
        public String bagItemName { get; set; }
        public String bagItemDescription { get; set; }

        override
        public String ToString()
        {
            String output;

            output = bagItemName + bagItemDescription + "\n";
            return output;
        }

    }
}
