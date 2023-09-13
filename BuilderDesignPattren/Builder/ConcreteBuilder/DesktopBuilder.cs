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
        // #Important: Add ISystemBuilder as a return type to achieve Fluent Interface Design Pattern
        public ISystemBuilder AddDriver(string type)
        {
            computer.HDDSize = type;
            return this; // return the computer object itslef like the ref param
        }

        public ISystemBuilder AddKeyboard(string type)
        {
            computer.Keyboard = type;
            return this; // return the computer object itslef like the ref param
        }

        public ISystemBuilder AddMemory(string type)
        {
            computer.RAM = type;
            return this; // return the computer object itslef like the ref param
        }

        public ISystemBuilder AddMouse(string type)
        {
            computer.Mouse = type;
            return this; // return the computer object itslef like the ref param
        }

        public ISystemBuilder AddTouchScreen(string type)
        {
            return this; // return the computer object itslef like the ref param
        }

        public ComputerSystem GetSystem()
        {
           return computer;
        }
    }
}
