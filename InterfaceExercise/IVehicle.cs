using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string NumberOfWheels { get; set; } 
        public string NumberOfSeats { get; set; }
        public string HasTrunk { get; set; }   
        public string NumberOfDoors { get; set; }   

    }
}
