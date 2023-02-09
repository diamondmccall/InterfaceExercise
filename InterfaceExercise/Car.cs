using System;
namespace InterfaceExercise  
{
    public class Car : IVehicle, ICompany
    {

        public Car()
        {
        }




        public int NumberOfWheels { get; set; } = 4;
        public bool HasWipers { get; set; } = true;
        public bool AuxCompatibility { get; set; } = true;
        public bool IsDrivable { get; set; } = true;
        public string Logos { get; set; } = ("");
        public string Luxury { get; set; } = ("");

        public bool HasTrunk { get; set; }





        public int NumberOfPassangers { get; set; }
    } 
}

