using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv
{

    class TechGuy : Superhero
    {
        public TechGuy()
        {
            intellegence = Superhero.Generator.Next(0, 20);
            magic = Superhero.Generator.Next(0, 15);
            strength = Superhero.Generator.Next(0, 10);

        }
    }
}
