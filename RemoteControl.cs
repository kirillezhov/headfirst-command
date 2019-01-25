using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6
{
    //Инициатор Invoker
    public class RemoteControl //Пульт управления
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;

        public RemoteControl() {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for(int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            this.onCommands[slot] = onCommand;
            this.offCommands[slot] = offCommand;
        }

        public void onButtonWasPressed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void offButtonWasPressed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonWasPressed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuff = new StringBuilder();

            stringBuff.Append("\r\n------- Remote Control --------\r\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append("[slot " + i + "] " + onCommands[i].GetType().Name + "    " + offCommands[i].GetType().Name + "\r\n");
            }

            return stringBuff.ToString();
        }
    }
}
