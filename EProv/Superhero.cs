using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv
{
    class Superhero
    {
        public static Random Generator = new Random();

        protected int strength;
        protected int intellegence;
        protected int magic;

        public string name;

        public int Study ()
        {
            int result = intellegence + Generator.Next(10);

            if (result > 20) { return 20; }
            else { return result; }
        }

        public int Fight ()
        {
            int result = strength + Generator.Next(10);

            if (result > 20) { return 20; }
            else { return result; }
        }

        public int ShowOff ()
        {
            int result = magic + Generator.Next(10);

            if (result > 20) { return 20; }
            else { return result; }
        }
        
    }
}
