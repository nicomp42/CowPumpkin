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
    class Program
    {
        static void Main(string[] args)
        {

            HalloweenCow myCow = new HalloweenCow("Angus");
            myCow.Carve = "Ghost";
            myCow.Decompose();

            Console.WriteLine("The cow has been carved to look like a " + myCow.Carve + ". It's decomposition status is: " + myCow.Decompose() + ". It's breed is " + myCow.breed);
        }
    }
}
