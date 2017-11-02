/*********************************************************
 * A halloween-themed demostration of interfaces
 * Bill Nicholson 
 * nicholdw@ucmail.uc.edu
 * *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowPumpkin {
    class Program {
        static void Main(string[] args) {

            Breed Angus = new Breed("Angus");
            Cow cow = new Cow(Angus);
            HalloweenCow HalloCow = new HalloweenCow(Angus);

            Console.WriteLine("The CowPumpkin has a " + HalloCow.Carve("") + "carved into it!");
            Console.WriteLine("Is the CowPumpkin decomposing?");
            if (HalloCow.Decompose() == true)
            {
                Console.WriteLine("The CowPumpkin is DYINGGGGG");
            }
            else
            {
                Console.WriteLine("It's alive, creepy, but alive");
            }

        }
    }
}
