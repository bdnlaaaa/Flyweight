using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class FlyweightFactory
    {
        Dictionary<string, Particle> particles = new Dictionary<string, Particle>();
        public FlyweightFactory()
        {
            particles.Add("Lavender", new LavenderParticle());
            particles.Add("Violet", new VioletParticle());
        }
        public Particle GetParticle(string key)
        {
            if (particles.ContainsKey(key))
                return particles[key];
            else
                return null;
        }
    }
}
