using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables - note classes are DATA TYPES TOO
            int myNum;
            Engine engine;
            Vehicle v1;

            // assigning variables
            myNum = 100;
            engine = new CombustionEngine(myNum, 50, "Petrol", 150, 1000);
            v1 = new MotorVehicle(engine, 5);

            // polymorphism
            // calling the inherited method from the parent class
            // seeing functionality overridden in child class
            v1.move();

            // assigning variables
            // car has an electric engine this time not a combustion engine
            engine = new ElectricEngine(100, 50, 150, 1000);
            v1 = new MotorVehicle(engine, 5);

            // polymorphism
            // calling the inherited method from the parent class
            // seeing functionality overridden in child class
            v1.move();

            // the mtor vehicel no longer exists - set to null
            v1 = null;

            // engine is an aggregartion because it still exists outside the motorvehicle
            engine.go();
            

            // other stuff from earlier in the class

            //v1 = new Horse("Mustang", 1);
            //v1.move();

            //MotorVehicle mv1; 
            //mv1 = new MotorVehicle("V8", myNum);
            //mv1.Start();
            //mv1.move();
            //mv1.TurnOff();

            //Horse h1;
            //h1 = new Horse("Mustang", 1);
            //h1.Eat();
            //h1.move();
            //h1.Poop();

            Console.ReadKey();
        }
    }
}
