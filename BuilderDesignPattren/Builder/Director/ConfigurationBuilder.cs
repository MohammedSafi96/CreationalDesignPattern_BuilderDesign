using BuilderDesignPattren.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattren.Builder.Director
{
    internal class ConfigurationBuilder
    {
        public void BuildSystem(ISystemBuilder systemBuilder, NameValueCollection collection)
        {
            // #Important: By ISystemBuilder as a return type we can get the methods by calling the functions values recursively like the LINQ, that is the Fluent Interface Design Pattern
            // Fluent Interface Design Pattern
            systemBuilder.AddDriver(collection["HDDSize"])
            .AddMemory(collection["RAM"])
            .AddKeyboard(collection["Keyboard"])
            .AddMouse(collection["Mouse"])
            .AddTouchScreen(collection["TouchScreen"]);

            // normal method
            //systemBuilder.AddDriver(collection["HDDSize"]);
            //systemBuilder.AddMemory(collection["RAM"]);
            //systemBuilder.AddKeyboard(collection["Keyboard"]);
            //systemBuilder.AddMouse(collection["Mouse"]);
            //systemBuilder.AddTouchScreen(collection["TouchScreen"]);
        }
    }
}
