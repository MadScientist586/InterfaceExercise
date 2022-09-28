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
            Car c1 = new Car();
            c1.CompanyName = "Toyota";
            c1.Logo = "simple";
            c1.IsCheap = "Yes";
            c1.NumberOfWheels = "four";
            c1.NumberOfDoors = "four";
            c1.NumberOfSeats = "five";
            c1.IsSmall = "Yes";
            c1.HasTrunk = "Yes";

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"The company name is {c1.CompanyName}.");
            Console.WriteLine($"The logo is {c1.Logo}.");
            Console.WriteLine($"Is the car cheap? {c1.IsCheap}.");
            Console.WriteLine($"The number of wheels is {c1.NumberOfWheels}.");
            Console.WriteLine($"The number of doors is {c1.NumberOfDoors}.");
            Console.WriteLine($"The number of seats is {c1.NumberOfSeats}.");
            Console.WriteLine($"Is the car small? {c1.IsSmall}");
            Console.WriteLine($"Does the car have a trunk? {c1.HasTrunk}.");




            Truck t1 = new Truck();
            t1.CompanyName = "Chevorlet";
            t1.Logo = "simple";
            t1.HasBed = "Yes";
            t1.NumberOfWheels = "four";
            t1.NumberOfDoors = "four";
            t1.NumberOfSeats = "five";
            t1.HasBackslideWindow = "Yes";
            t1.HasTrunk = "No";

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"The company name is {t1.CompanyName}.");
            Console.WriteLine($"The logo is {t1.Logo}");
            Console.WriteLine($"Does the truck have a bed? {t1.HasBed}.");
            Console.WriteLine($"The number of wheels is {t1.NumberOfWheels}.");
            Console.WriteLine($"The number of doors is {t1.NumberOfDoors}.");
            Console.WriteLine($"The number of seats is {t1.NumberOfSeats}.");
            Console.WriteLine($"Does the truck have a Backslide window? {t1.HasBackslideWindow}.");
            Console.WriteLine($"Does the truck have a trunk? {t1.HasTrunk}.");



            SUV suv1 = new SUV();
            suv1.CompanyName = "Chevorlet";
            suv1.Logo = "simple";
            suv1.Is3Row = "Yes";
            suv1.NumberOfWheels = "four";
            suv1.NumberOfDoors = "four";
            suv1.NumberOfSeats = "eight";
            suv1.HasTrunk = "Yes";
            suv1.HasSpaciousTrunk = "No";

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"The company name is {suv1.CompanyName}.");
            Console.WriteLine($"The logo is {suv1.Logo}.");
            Console.WriteLine($"Is the SUV a three row? {suv1.Is3Row}.");
            Console.WriteLine($"The number of wheels is {suv1.NumberOfWheels}.");
            Console.WriteLine($"The number of doors is {suv1.NumberOfDoors}.");
            Console.WriteLine($"The number of seats is {suv1.NumberOfSeats}.");
            Console.WriteLine($"Does the SUV have a trunk? {suv1.HasTrunk}.");
            Console.WriteLine($"Does the SUV have spacious trunk? {suv1.HasSpaciousTrunk}.");
        }
    }
}
