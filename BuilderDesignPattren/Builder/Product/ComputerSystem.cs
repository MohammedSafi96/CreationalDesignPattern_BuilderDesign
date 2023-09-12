using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattren.Builder.Product
{
    internal class ComputerSystem
    {
        public string RAM { get; set; }
        public string HDDSize { get; set; }
        public string Keyboard { get; set; }
        public string Mouse { get; set; }
        public string TouchScreen { get; set; }
    }
}
