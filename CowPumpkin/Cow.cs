/*********************************************************
 * A halloween-themed demostration of interfaces
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu 
 * edited by Bradley Bruce
 * *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowPumpkin {
    class Cow {
        /// <summary>
        /// The breed of the cow
        /// </summary>
        public Breed breed { get; set; }

        public Cow(Breed breed) {
            this.breed = breed;
        }

    }
}
