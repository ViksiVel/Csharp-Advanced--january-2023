using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing2
{
    public class Car
    {
        //private string model;
        //private double fuelAmount;
        //private double fuelConsumptionPerKilometer;
        //private double travelDistance;

        
        public string Model { get; set; }
       
        public double TravelDistance { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }
    
        public double FuelAmount { get; set; }

        public void Drive(double distance)
        {
            //Ako podadenata stoinost/distance/ ymnojena po gorivoto za 1 km/vzimame ot property-to, zashoto iskame da moje da se promenq/ e po-golqmo ot gorivoto, koeto ima kolata /vzimame gorivoto ot field-a, zashoto iskame da e originalnoto - nepromenenoto/
            if (distance * FuelConsumptionPerKilometer > FuelAmount)
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= distance * FuelConsumptionPerKilometer;
                TravelDistance += distance;
            }
        }




    }
}
