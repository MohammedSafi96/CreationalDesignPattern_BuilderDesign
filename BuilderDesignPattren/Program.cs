
using BuilderDesignPattren.Builder.ConcreteBuilder;
using BuilderDesignPattren.Builder.Director;
using BuilderDesignPattren.Builder.IBuilder;
using BuilderDesignPattren.Builder.Product;
using System.Collections.Specialized;

ISystemBuilder desktop = new DesktopBuilder();

ConfigurationBuilder desktopBuilder = new ConfigurationBuilder();
NameValueCollection pairs = new NameValueCollection();
pairs.Add("HDDSize", "1T");
pairs.Add("RAM", "32GB");
pairs.Add("Keyboard", "k1");
pairs.Add("Mouse", "m1");
desktopBuilder.BuildSystem(desktop,  pairs);
ComputerSystem system = desktop.GetSystem();

Console.WriteLine($"Desktop Details => HDDSize: {system.HDDSize}, RAM: {system.RAM}, Keyboard:{system.Keyboard}, Mouse:{system.Mouse}");



ISystemBuilder laptop = new LaptopBuilder();

ConfigurationBuilder laptopBuilder = new ConfigurationBuilder();
NameValueCollection pairs2 = new NameValueCollection();
pairs2.Add("HDDSize", "500GB");
pairs2.Add("RAM", "16GB");
pairs2.Add("TouchScreen", "true");
laptopBuilder.BuildSystem(laptop, pairs2);
ComputerSystem system2 = laptop.GetSystem();

Console.WriteLine($"Laptop Details => HDDSize: {system2.HDDSize}, RAM: {system2.RAM}, TouchScreen:{system2.TouchScreen}");

Console.ReadLine();