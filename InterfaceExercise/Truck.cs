using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string NumberOfWheels { get; set; }
        public string NumberOfSeats { get; set; }
        public string HasTrunk { get; set; }
        public string NumberOfDoors { get; set; }
    
        public string HasBed { get; set; }
        public string HasBackslideWindow { get; set; } 
    }
}
