using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class LavenderParticle : Particle
    {
        public LavenderParticle()
        {
            color = "Lavender";
        }
        public override void Create(double x, double y)
        {
            Console.WriteLine("Created a lavender particle at ({0}, {1})", x, y);
        }
    }
}
