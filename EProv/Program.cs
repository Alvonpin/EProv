using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv
{
    //Har ej hunnit kommentera

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select a hero type. Type either a, b or c");
            Console.WriteLine("a) Mutant");
            Console.WriteLine("b) God");
            Console.WriteLine("c) Tech Guy");

            bool sucess = false;
            while (sucess == false)

            {
                string input = InputManager.GetInputChoises(out sucess, "a", "b", "c");
                if (sucess == false) { Console.WriteLine("Please type either a, b or c"); }

                else
                {
                    if (input == "a") { Mutant playerHero = new Mutant(); }
                    else if (input == "b") {God playerHero = new God(); }
                    else { TechGuy playerHero = new TechGuy(); }
                }

            }


            Console.ReadLine();


        }
    }
}
