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
            LightOffCommand livingRoomLightOff= new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenRoomLightOn = new LightOnCommand(kitchenRoomlight);
            LightOffCommand kitchenRoomLightOff = new LightOffCommand(kitchenRoomlight);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWidthCDCommand stereoOnWidthCDCommand = new StereoOnWidthCDCommand(stereo);
            StereoOffWidthCDCommand stereoOffWidthCDCommand = new StereoOffWidthCDCommand(stereo);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenRoomLightOn, kitchenRoomLightOff);
            remote.SetCommand(2, garageDoorUp, garageDoorDown);
            remote.SetCommand(3, stereoOnWidthCDCommand, stereoOffWidthCDCommand);

            Console.WriteLine(remote.ToString());

            remote.onButtonWasPressed(0);
            remote.undoButtonWasPressed();
            remote.offButtonWasPressed(0);
            remote.onButtonWasPressed(1);
            remote.offButtonWasPressed(1);
            remote.onButtonWasPressed(2);
            remote.offButtonWasPressed(2);
            remote.undoButtonWasPressed();
            remote.onButtonWasPressed(3);
            remote.offButtonWasPressed(3);

            Console.ReadKey();
        }
    }
}
