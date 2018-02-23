using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Class Types ******\n");
            // Allocate and configure a Car object.
            Car myCar = new Car //this could also be Car myCar = new Car(); and the properties could be set by myCar.currSpeed = 10; myCar.petName = "Henry";
            {
                currSpeed = 10,
                petName = "Henry"
            };
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            
            Car Chuck = new Car();
            Chuck.PrintState(); // here we see the new constructor already set the values of the Car class properties to a new default

            Car Mary = new Car("Mary");
            Mary.PrintState();

            Car Daisy = new Car("Daisy", 75);
            Daisy.PrintState();

            // we just used the new overloaded constructor to create three cars. It was much quicker to initialize a new instance of Car and fill out field data

            Console.ReadLine();
        }
    }
}
