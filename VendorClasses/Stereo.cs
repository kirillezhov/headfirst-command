using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.VendorClasses
{
    public class Stereo
    {
        string Name;

        public Stereo(string Name)
        {
            this.Name = Name;
        }
        public void On() => Console.WriteLine(Name + " stereo is on");
        public void Off() => Console.WriteLine(Name + " stereo is off");
        public void SetCD() => Console.WriteLine(Name + " stereo is set for CD input");
        public void SetVolume(int value) => Console.WriteLine(Name + " stereo volume set to " + value);
    }
}
