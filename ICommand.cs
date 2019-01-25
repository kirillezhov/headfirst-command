using Chapter_6.VendorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class NoCommand : ICommand
    {
        public void Execute() { }
        public void Undo() { }
    }

    public class LightOnCommand : ICommand
    {
        Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }

    public class LightOffCommand : ICommand
    {
        Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
    }

    public class GarageDoorUpCommand : ICommand
    {
        GarageDoor garageDoor;
        public GarageDoorUpCommand(GarageDoor garageDoor) => this.garageDoor = garageDoor;

        public void Execute()
        {
            garageDoor.Up();
        }

        public void Undo()
        {
            garageDoor.Down();
        }
    }

    public class GarageDoorDownCommand : ICommand
    {
        GarageDoor garageDoor;
        public GarageDoorDownCommand(GarageDoor garageDoor) => this.garageDoor = garageDoor;

        public void Execute()
        {
            garageDoor.Down();
        }

        public void Undo()
        {
            garageDoor.Up();
        }
    }

    public class StereoOnWidthCDCommand : ICommand
    {
        Stereo stereo;

        public StereoOnWidthCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }

    public class StereoOffWidthCDCommand : ICommand
    {
        Stereo stereo;

        public StereoOffWidthCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }
    }
}
