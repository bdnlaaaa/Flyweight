using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class VioletParticle : Particle
    {
        public VioletParticle()
        {
            color = "Violet";
        }
        public override void Create(double x, double y)
        {
            Console.WriteLine("Created a violet particle at ({0}, {1})", x, y);
        }
    }
}
