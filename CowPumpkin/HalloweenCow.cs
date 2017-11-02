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

        public bool Decompose()
        {
            bool resultOfDecomposition = false;
            if ((new Random()).Next() % 2 == 1) { resultOfDecomposition = true; }
            return resultOfDecomposition;
        }

        public String Carve(String Shape)
        {
            String resultShape;
            bool shapeDesign = false;
            if ((new Random()).Next() % 2 == 1){ shapeDesign = true; }
            if (shapeDesign == true){ resultShape = "Spooky Face "; }
            else{ resultShape = "Cat Face "; }

            return resultShape;
        }

    }
}
