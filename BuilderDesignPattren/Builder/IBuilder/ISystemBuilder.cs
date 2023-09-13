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
        // #Important: Add ISystemBuilder as a return type to achieve Fluent Interface Design Pattern
        ISystemBuilder AddMemory(string type);
        ISystemBuilder AddDriver(string type);
        ISystemBuilder AddMouse(string type);
        ISystemBuilder AddKeyboard(string type);
        ISystemBuilder AddTouchScreen(string type);
        ComputerSystem GetSystem();
    }
}
