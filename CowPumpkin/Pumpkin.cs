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
    /// <summary>
    /// Define how a Pumpkin should behave
    /// </summary>
    interface Pumpkin {
        /// <summary>
        /// Decompose into an amorphous blob. This happens shortly after Halloween to all pumpkins
        /// </summary>
        void Decompose();

        void Carve(String shape);

        
    }
}
