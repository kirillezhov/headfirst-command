using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6
{
    //Инициатор Invoker
    public class SimpleRemoteControl //Пульт управления
    {
        ICommand slot;
        public SimpleRemoteControl() { }

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
