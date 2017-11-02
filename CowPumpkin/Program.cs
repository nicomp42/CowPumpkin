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
    class Program {
        static void Main(string[] args) {
            Breed spot = new Breed("Longhorn");
            HalloweenCow moo = new HalloweenCow(spot);
            moo.Carve("oblong");
            moo.Decompose();
        }
    }
}
