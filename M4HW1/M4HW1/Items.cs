using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    class Items
    {
        public String itemName { get; set; }
        public String itemDescription { get; set; }
        public bool isEquiped { get; set; }
        public bool received { get; set; }
        public bool isFilled { get; set; }

        public Items()
        {
            name = this.itemName;
            description = this.itemDescription;
        }

        public string name { get; set; }
        public string description { get; set; }

        override
        public String ToString()
        {
            String output;

            output = itemName + "\n" + itemDescription + "\n";
            return output;
        }

    }
}
