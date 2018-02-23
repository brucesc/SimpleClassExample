using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // The 'state' of the Car.
        public string petName;
        public int currSpeed;

        // The functionality of the Car.
        // Using the expression-bodied member syntax introduced in C# 6 
        public void PrintState()
            => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);

        public void SpeedUp(int delta)
            => currSpeed += delta;
       
        // we learned that we can overload a class and supposedly a method, but we can also overload a constructor
        // a constructor definition is on page 165, but here is an example of one
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        public Car(string pn)
        {
            petName = pn;
        }
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }
        
        // The snippet ctor tab tab can be used to quickly create a custom constructor
    }
    






}











