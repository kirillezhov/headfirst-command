using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.VendorClasses
{
    //Receiver
    public class Light
    {
        string Name;

        public Light(string Name)
        {
            this.Name = Name;
        }

        public void On()
        {
            Console.WriteLine(Name + " Light is On");
        }

        public void Off()
        {
            Console.WriteLine(Name + " Light is Off");
        }
    }
}
