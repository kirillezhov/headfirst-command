using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.VendorClasses
{
    public class GarageDoor
    {
        string Name;

        public GarageDoor(string Name)
        {
            this.Name = Name;
        }

        public void Up()
        {
            Console.WriteLine(Name + " Garage Door is Open");
        }

        public void Down()
        {
            Console.WriteLine(Name + " Garage Door is Close");
        }
    }
}
