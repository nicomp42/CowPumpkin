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
    /// <summary>
    /// Breed of cow. For now, it's simply a String. That could change, however, therfore we made it a class.
    /// </summary>
    class Breed
    {
        private String mBreed;
        /// <summary>
        /// Constructor. 
        /// </summary>
        /// <param name="breed">A string defining the breed</param>
        public Breed(String breed)
        {
            SetBreed(breed);
        }
        /*public String breed {
            get { return mBreed; }
            set { SetBreed(value); }
        }*/
        private void SetBreed(String breed)
        {
            if (breed.Trim().Length > 0)
            {
                this.mBreed = breed;
            }
            else
            {
                throw new Exception("Breed: breed cannot be zero length");
            }
        }
    }
}
