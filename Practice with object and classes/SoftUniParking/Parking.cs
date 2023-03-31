using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;

        private int capacity;

       public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary<string, Car>();
        }

        public int Count { get { return this.cars.Count; } }

        public string AddCar(Car car) //tyk suzdavame metod s koito suzdavame kola i priemame stoinost ot klasa kola s ime kola
        {
            if (cars.ContainsKey(car.RegistrationNumber))//ako dictionary-to sudurja registracionniq nomer, togava kazvame che veche q ima i spira komandata
            {
                return "Car with that registration number, already exists!";
            }
            if (cars.Count == capacity)//ako parkinga e pulen vrushta che e pulen i spira komandata
            {
                return "Parking is full!";
            }
            //ako drugite proverki ne sa izpulneni oznachava che kolata q nqma, v parkinga ima mqsto i q dobavqme i vrushtame che e dobavena yspeshno i spira komandata
            this.cars.Add(car.RegistrationNumber, car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            return cars[registrationNumber];
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!cars.ContainsKey(registrationNumber))
            {
                return $"Car with that registration number, doesn't exist!";
               
            }
            else
            {
                cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                RemoveCar(registrationNumber);
            }
        }

    }
}
