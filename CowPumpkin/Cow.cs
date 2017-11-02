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
    class Cow
    {
        /// <summary>
        /// The breed of the cow
        /// </summary>
        public String breed { get; set; }

        public Cow(String breed)
        {
            this.breed = breed;
        }

    }
}
