using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.VendorClasses
{
    public class CellingFan
    {
        public enum Speed{
            OFF = 0,
            LOW,
            MEDIUM,
            HIGH
        }

        string location;
        int speed;

        public CellingFan(string location)
        {
            this.location = location;
            speed = (int)Speed.OFF;
        }

        public void High()
        {
            speed = (int)Speed.HIGH;
            Console.WriteLine(location + " ceiling fan is on high");
        }

        public void Medium()
        {
            speed = (int)Speed.MEDIUM;
            Console.WriteLine(location + " ceiling fan is on medium");
        }

        public void Low()
        {
            speed = (int)Speed.LOW;
            Console.WriteLine(location + " ceiling fan is on low");
        }

        public void Off()
        {
            speed = (int)Speed.OFF;
            Console.WriteLine(location + " ceiling fan is off");
        }

        public int GetSpeed() => speed;
    }
}
