using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisSingletonFruit
{
    // Allow passing of the child's objects properties. 
    public class Apple : Fruit
    {
        // Get and Set the Property Color.
        public string Color { get; set; }

        //Default Apple Constructor.
        public Apple()
        {
        }

        // Call's the default Apple Constructor.
        public Apple(string color, int weight)
        {
            Color = color;
            Weight = weight;
        }
    }
}

