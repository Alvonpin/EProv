using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv
{
    class Mutant : Superhero
    {
        private string element;

        public Mutant()
        {
            strength = Superhero.Generator.Next(0, 20);
            intellegence = Superhero.Generator.Next(0, 15);
            magic = Superhero.Generator.Next(0, 10);

        }
    }
}
