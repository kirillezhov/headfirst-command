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
            RemoteControl remote = new RemoteControl();
            Light kitchenRoomlight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            GarageDoor garageDoor = new GarageDoor("");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenRoomLightOn = new LightOnCommand(kitchenRoomlight);
            LightOffCommand kitchenRoomLightOff = new LightOffCommand(kitchenRoomlight);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWidthCDCommand stereoOnWidthCDCommand = new StereoOnWidthCDCommand(stereo);
            StereoOffWidthCDCommand stereoOffWidthCDCommand = new StereoOffWidthCDCommand(stereo);

            ICommand[] partyOn = { livingRoomLightOn, garageDoorUp, stereoOnWidthCDCommand, kitchenRoomLightOn };
            ICommand[] partyOff = { livingRoomLightOff, garageDoorDown, stereoOffWidthCDCommand, kitchenRoomLightOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remote.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remote);
            Console.WriteLine("--- Pushing Macro On ---");
            remote.onButtonWasPressed(0);
            Console.WriteLine("--- Pushing Macro Off ---");
            remote.offButtonWasPressed(0);

            Console.ReadKey();
        }
    }
}
