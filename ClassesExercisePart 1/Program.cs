using System;

namespace ClassesExercisePart_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = "2013";

            var Mazda = new Car();
            {
                string Make = "Mozda";
                string Model = "CX-5";
                string Year = "2016";

            };

            var chevy = new Car("chevy", "Impala", 2001);

            var carList = new List<Car>() { "myCar", "Mozda", "chevy" };
            Console.WriteLine(carList.Capacity);

            foreach (var vehicle in carList);
            
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }

           

        }
    }
}
