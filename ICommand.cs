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
    }

    public class LightCommand : ICommand
    {
        Light light;
        public LightCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }

    public class GarageDoorCommand : ICommand
    {
        GarageDoor garageDoor;
        public GarageDoorCommand(GarageDoor garageDoor) => this.garageDoor = garageDoor;

        public void Execute()
        {
            garageDoor.Up();
        }
    }
}
