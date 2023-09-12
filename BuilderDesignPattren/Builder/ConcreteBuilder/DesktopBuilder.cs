using BuilderDesignPattren.Builder.IBuilder;
using BuilderDesignPattren.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattren.Builder.ConcreteBuilder
{
    internal class DesktopBuilder : ISystemBuilder
    {
        ComputerSystem computer = new ComputerSystem();

        public void AddDriver(string type)
        {
            computer.HDDSize = type;
        }

        public void AddKeyboard(string type)
        {
            computer.Keyboard = type;
        }

        public void AddMemory(string type)
        {
            computer.RAM = type;
        }

        public void AddMouse(string type)
        {
            computer.Mouse = type;
        }

        public void AddTouchScreen(string type)
        {
           return;
        }

        public ComputerSystem GetSystem()
        {
           return computer;
        }
    }
}
