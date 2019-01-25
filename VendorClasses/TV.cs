using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.VendorClasses
{
    public class TV
    {
        string location;

        public TV(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine(location + " TV is on");
        }

        public void SetInputChannel(string channel)
        {
            Console.WriteLine(location + " TV is set for " + channel);
        }
        //Other methods
    }
}
