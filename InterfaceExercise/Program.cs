using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var myCar = new Car();
            var myTruck = new Truck();
            var mySuv = new Suv();

          
         
            myCar.Logos = ("Lexus");
            myCar.Luxury = ($"You're driving experience is Luxury");
            myCar.NumberOfPassangers = 4;
            myCar.HasTrunk = true;
 
            mySuv.AuxCompatibility = false;
            mySuv.CompanyCar = true;
            mySuv.Logos = ($"Bmw");
            mySuv.ReverseSensor = false;
            mySuv.Luxury = ($"not so much");
           




            myTruck.AuxCompatibility = true;
            myTruck.BedSize = ("Single Passanger Bed");
            myTruck.HasWipers = true;
            myTruck.IsSemi = false;
            myTruck.Logos = ($"Grey Hound!");
            myTruck.Luxury = ($"Not So much");

            
            Console.WriteLine($"My {myTruck.Logos} trucl has a {myTruck.BedSize}. It is {myTruck.AuxCompatibility} that i can use an aux, and my truck comes in Luxury but mine is {myTruck.Luxury}. It is {myTruck.IsSemi} that my truck is a semi and has {myTruck.NumberOfWheels} wheels, but is {myTruck.HasWipers}, that i have wipers and {myTruck.IsDrivable} that is is drivable.");
            Console.WriteLine($"-----");
            Console.WriteLine($"It is that my {mySuv.CompanyCar} that my {mySuv.Logos} Suv is a company car. My Suv has {mySuv.NumberOfWheels} wheels and it is {mySuv.AuxCompatibility} that i can use my aux cord. It is {mySuv.HasWipers} that ny windshiel whipers work, but {mySuv.Luxury}. It is {mySuv.ReverseSensor} that i have a reverse camera, but {mySuv.IsDrivable} that it is easy to drive.");
            Console.WriteLine($"-----");
            Console.WriteLine($"My {myCar.Logos} has {myCar.NumberOfWheels} wheels, and it is {myCar.AuxCompatibility} that i can use an aux cord. It is {myCar.HasTrunk} that i have a trunk, and seat {myCar.NumberOfPassangers} passengers at a time. Also, {myCar.Luxury} and {myCar.IsDrivable} that is is driveable. It is also {myCar.HasWipers} that I have updated wipers.");
           


        }
    }
}
