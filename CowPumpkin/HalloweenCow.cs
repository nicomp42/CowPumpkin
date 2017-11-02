/*********************************************************
 * A halloween-themed demostration of interfaces
 * Bill Nicholson 
 * nicholdw@ucmail.uc.edu
 * edited on 11/2/17 by crueybm
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

        public void Carve(String shape) {
            Console.WriteLine("The pumpkin is " + shape);
        }

        public void Decompose() {
            for (int i = 0; i > 14; i++) {
                Console.WriteLine("The pumpkin is " + i + " days decomposed.");
            }
        }
    }
}
