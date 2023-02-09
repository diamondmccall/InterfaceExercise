using System;
namespace InterfaceExercise 
{
	public class Truck : IVehicle , ICompany
	{
		public Truck()
		{
			
		}

		public int NumberOfWheels { get; set; } = 8;
		public bool HasWipers { get; set; } = true;
		public bool AuxCompatibility { get; set; } = true;
		public bool IsDrivable { get; set; } = true;
		public string Logos { get; set; } = ($"");
		public string Luxury { get; set; } = ($"");

		public string BedSize { get; set; } = ($"");
		public bool IsSemi { get; set; } = false;
	}

	
}

