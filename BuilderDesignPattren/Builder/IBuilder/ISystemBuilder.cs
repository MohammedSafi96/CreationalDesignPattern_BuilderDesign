using BuilderDesignPattren.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattren.Builder.IBuilder
{
    internal interface ISystemBuilder
    {
        void AddMemory(string type);
        void AddDriver(string type);
        void AddMouse(string type);
        void AddKeyboard(string type);
        void AddTouchScreen(string type);
        ComputerSystem GetSystem();
    }
}
