using System;
namespace InterfaceExercise
{
	public class Suv :IVehicle, ICompany
	{
		public Suv()
		{
		}
        public int NumberOfWheels { get; set; } = 4;
        public bool HasWipers { get; set; } = true;
        public bool AuxCompatibility { get; set; } = true;
        public bool IsDrivable { get; set; } = true;
        public string Logos { get; set; } = ($"");
        public string Luxury { get; set; } = ($"");

        public bool CompanyCar { get; set; }
		public bool ReverseSensor { get; set; }
	}
}

