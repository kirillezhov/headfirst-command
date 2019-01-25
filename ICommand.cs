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

    public class CeilingFanCommand : ICommand
    {
        protected CellingFan cellingFan;
        protected int prevSpeed;

        public CeilingFanCommand(CellingFan cellingFan)
        {
            this.cellingFan = cellingFan;
        }

        public virtual void Execute()
        {
            prevSpeed = cellingFan.GetSpeed();
            cellingFan.High();
        }

        public void Undo()
        {
            if(prevSpeed == (int)CellingFan.Speed.HIGH)
            {
                cellingFan.High();
            }
            else if(prevSpeed == (int)CellingFan.Speed.MEDIUM)
            {
                cellingFan.Medium();
            }
            else if(prevSpeed == (int)CellingFan.Speed.LOW)
            {
                cellingFan.Low();
            }
            else if(prevSpeed == (int)CellingFan.Speed.OFF)
            {
                cellingFan.Off();
            }
        }
    }

    public class CeilingFanHighCommand : CeilingFanCommand
    {
        public CeilingFanHighCommand(CellingFan cellingFan) : base(cellingFan) { }
        public override void Execute()
        {
            prevSpeed = cellingFan.GetSpeed();
            cellingFan.High();
        }
    }

    public class CeilingFanLowCommand : CeilingFanCommand
    {
        public CeilingFanLowCommand(CellingFan cellingFan) : base(cellingFan) { }
        public override void Execute()
        {
            prevSpeed = cellingFan.GetSpeed();
            cellingFan.Low();
        }
    }

    public class CeilingFanMediumCommand : CeilingFanCommand
    {
        public CeilingFanMediumCommand(CellingFan cellingFan) : base(cellingFan) { }
        public override void Execute()
        {
            prevSpeed = cellingFan.GetSpeed();
            cellingFan.Medium();
        }
    }

    public class CeilingFanOffCommand : CeilingFanCommand
    {
        public CeilingFanOffCommand(CellingFan cellingFan) : base(cellingFan) { }
        public override void Execute()
        {
            prevSpeed = cellingFan.GetSpeed();
            cellingFan.Off();
        }
    }

    public class MacroCommand : ICommand
    {
        ICommand[] commands;

        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            for (int i = 0; i < commands.Length; i++)
                commands[i].Execute();
        }

        public void Undo()
        {
            for (int i = 0; i < commands.Length; i++)
                commands[i].Undo();
        }
    }
}
