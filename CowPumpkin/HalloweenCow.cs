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
    class HalloweenCow : Cow, Pumpkin {
        public HalloweenCow(Breed breed) : base(breed) {

        }
    }
}
