using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv
{
    class InputManager
    {
        static public string GetInputChoises(out bool sucess, string choiseA, string choiseB, string choiseC)
        {
            string input = Console.ReadLine();

            if (input == choiseA || input == choiseB || input == choiseC) { sucess = true; return input; }
            else { sucess = false;  return null; }
        }
    }
}
