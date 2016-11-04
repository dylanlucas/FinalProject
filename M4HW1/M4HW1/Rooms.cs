using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    class Rooms
    {
        public String roomName { get; set; }
        public String roomDescription { get; set; }
        public bool LocationToNorth { get; set; }
        public bool LocationToEast { get; set; }
        public bool LocationToSouth { get; set; }
        public bool LocationToWest { get; set; }

        public Rooms()
        {
            rName = this.roomName;
            rDesc = this.roomDescription;
            northExit = this.LocationToNorth;
            eastExit = this.LocationToEast;
            southExit = this.LocationToSouth;
            westExit = this.LocationToWest;
        }

        public Object objectsInRoom { get; set; }

        public String rName { get; set; }
        public String rDesc { get; set; }
        public bool northExit { get; set; }
        public bool eastExit { get; set; }
        public bool southExit { get; set; }
        public bool westExit { get; set; }

        override
        public String ToString()
        {
            String output;

            output = roomName + "\n" + roomDescription + "\n";
            return output;
        }
    }
}
