using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv
{
    class God : Superhero
    {
        public God()
        {
            magic = Superhero.Generator.Next(0, 20);
            strength = Superhero.Generator.Next(0, 15);
            intellegence = Superhero.Generator.Next(0, 10);

        }

    }
}
