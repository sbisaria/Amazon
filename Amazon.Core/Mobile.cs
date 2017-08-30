using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Core
{
    public class Mobile:Item
    {
        public string Dimension { get; set; }
        public Color Color { get; set; }
        public Battery BatteryType { get; set; }
        public Memory Memory { get; set; }
        public string ImageUrl { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
