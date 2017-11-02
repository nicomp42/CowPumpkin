/*********************************************************
 * A halloween-themed demostration of interfaces
 * Bill Nicholson 
 * nicholdw@ucmail.uc.edu
 * modified by Jeremy Ring 1 November 2017
 * *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowPumpkin
{
    class HalloweenCow : Cow, Pumpkin
    {
        public HalloweenCow(String breed) : base(breed)
        {

        }

        public String Decompose()
        {
            bool isDecomposed = false;
            String decomposeStatus = "Not an amorphous blob yet";
            if ((new Random()).Next() % 2 == 1) { isDecomposed = true; }
            if (isDecomposed == true)
            {
                decomposeStatus = "amorphous blob";
            }

            return decomposeStatus;

        }

        public String Carve { get; set; }
    }
}
