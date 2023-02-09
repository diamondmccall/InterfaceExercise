using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int NumberOfWheels { get; set; }
		public bool HasWipers { get; set; }
		public bool AuxCompatibility { get; set; }
		public bool IsDrivable { get; set; }
	}
}	
