using System;


namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            
            car.Drive(10);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
