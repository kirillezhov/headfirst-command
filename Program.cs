using Chapter_6.VendorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();
            LightCommand lightCommand = new LightCommand(light);
            GarageDoorCommand doorCommand = new GarageDoorCommand(garageDoor);

            remote.SetCommand(lightCommand);
            remote.ButtonWasPressed();
            remote.SetCommand(doorCommand);
            remote.ButtonWasPressed();

            Console.ReadKey();
        }
    }
}
