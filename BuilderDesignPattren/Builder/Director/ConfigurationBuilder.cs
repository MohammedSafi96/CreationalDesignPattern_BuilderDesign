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
            systemBuilder.AddDriver(collection["HDDSize"]);
            systemBuilder.AddMemory(collection["RAM"]);
            systemBuilder.AddKeyboard(collection["Keyboard"]);
            systemBuilder.AddMouse(collection["Mouse"]);
            systemBuilder.AddTouchScreen(collection["TouchScreen"]);
        }
    }
}
