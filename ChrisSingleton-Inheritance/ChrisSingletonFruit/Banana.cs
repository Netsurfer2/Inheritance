using ChrisSingletonFruit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisSingletonFruit
{

    // Use the Constructor with parameters to allow passing of the child Banana objects properties.
    public class Banana : Fruit

    {    
        // Get and Set the Properties Color and Imported.
        public string Color { get; set; }
        public bool Imported { get; set; }


        // Default Banana Constructor.
        public Banana()
        {

        }



        // Child Banana's Constructor with Parameters weight and imported.
        public Banana(string color, int weight, bool imported)
        {
            Color = color;
            Weight = weight;
            Imported = imported;
        }
    }
}

