using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Contains the Main method and AddPassenger function
     * Restrictions: None
     */ 
    internal class Program
    {
        /* Method: Main
         * Purpose: None
         * Restrictions: None
         */
        static void Main(string[] args)
        {
        }
        /* Function: AddPassenger
         * Purpose: Accepts any object form the IPassengerCarrier interface
         * Restrictions: None
         */
        public void AddPassenger(IPassengerCarrier vehicleObject)
        {
            vehicleObject.LoadPassenger();
            vehicleObject.ToString();
        }
    }
}