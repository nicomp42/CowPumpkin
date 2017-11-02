/*********************************************************
 * A halloween-themed demostration of interfaces
 * Bill Nicholson 
 * nicholdw@ucmail.uc.edu
 *  * edited by Bradley Bruce
 * *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowPumpkin {
    class HalloweenCow : Cow, Pumpkin {
        public HalloweenCow(Breed breed) : base(breed) {

        }


        //added these methods to fix the missing methods from pumkin
        public void Carve(string shape)
        {
            Console.WriteLine("HalloweenCow is now Carved");
        }

        public void Decompose()
        {
            Console.WriteLine("HalloweenCow is now a lump of mush");
        }
    }
}
