using BuilderDesignPattren.Builder.IBuilder;
using BuilderDesignPattren.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattren.Builder.ConcreteBuilder
{
    internal class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem computer = new ComputerSystem();

        public void AddDriver(string type)
        {
            computer.HDDSize = type;
        }

        public void AddKeyboard(string type)
        {
            return;
        }

        public void AddMemory(string type)
        {
            computer.RAM = type;    
        }

        public void AddMouse(string type)
        {
           return;
        }

        public void AddTouchScreen(string type)
        {
           computer.TouchScreen = type;
        }
        public ComputerSystem GetSystem()
        {
            return computer;
        }
    }
}
