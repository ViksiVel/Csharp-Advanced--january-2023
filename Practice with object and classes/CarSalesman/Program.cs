using System;
using System.Collections.Generic;

namespace CarSalesman;

public class Program
{
    static void Main()
    {
        List<Car> cars = new();
        List<Engine> engines = new();


        int countEngines = int.Parse(Console.ReadLine());

        for (int i = 0; i < countEngines; i++)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Engine engine = CreateEngine(tokens);

            engines.Add(engine);

        }

        int countCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < countCars; i++)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = CreateCar(tokens, engines);
            cars.Add(car);

        }
        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }


        static Engine CreateEngine(string[] engineProperties) //slagame Array, zashtoto priemame array, tova e kato tokens
        {
            Engine engine = new(engineProperties[0], int.Parse(engineProperties[1]));

            if (engineProperties.Length > 2) //ako duljinata na engineProperties e po-golqm ot 2, tova oznachava, che imame dobavena stoinost (displacemen, efficiency) i sega proverqvame kakvo e polucheno
            {
                int displacement;

                bool isDigit = int.TryParse(engineProperties[2], out displacement); //Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded.

                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = engineProperties[2];
                }

                
                if (engineProperties.Length > 3) //tyk proverqvame dali duljinata e poveche ot 3, ako e poveche oznachava, che imame vsichkite parametri i tova oznachava che na engineProperties[2] sus sigurnost e displacement, za tova napravo na engineProperties[3] prisvoqvame efficiency
                {
                    engine.Efficiency = engineProperties[3];
                }


            }
            return engine;
        }
        static Car CreateCar(string[] carProperties,List<Engine> engines) //slagame Array, zashtoto priemame array, tova e kato tokens i  shte priemame list ot Engines
        {
            Engine engine = engines.Find(x => x.Model == carProperties[1]);//Tyk suzdavame promenliva ot klasa Engine i vutre tursim imeto na Model-a, koeto da e ravno na carProperties[1]

            Car car = new(carProperties[0], engine); //Tyk suzdavame obekt ot Car i my davame Model-a i vzimame obektta engine

            if (carProperties.Length > 2)
            {
                int weight;

                bool isDigit = int.TryParse(carProperties[2], out weight);//Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded. - > Proverqva dali moje da se prevurne v chislo, ako moje znachi e true 

                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carProperties[2];
                }

                if (carProperties.Length > 3)//tyk proverqvame dali duljinata e poveche ot 3, ako e poveche oznachava, che imame vsichkite parametri i tova oznachava che na carProperties[2] sus sigurnost e weight, za tova napravo na carProperties[3] prisvoqvame color
                {
                    car.Color = carProperties[3];
                }
            }
            return car;



        }
    }

}
