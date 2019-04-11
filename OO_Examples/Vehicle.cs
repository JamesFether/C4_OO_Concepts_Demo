using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Examples
{
    public abstract class Vehicle
    {
        public int capacity;
        public Vehicle(int pCapacity)
        {
            capacity = pCapacity;
        }
        public abstract void move();
    }


    public class MotorVehicle :Vehicle
    {
        public Engine engine;
        public MotorVehicle(Engine pEngine, int pCapacity):base(pCapacity)
        {
            engine = pEngine;
        }
        public void Start()
        {
            Console.WriteLine("t t t t t t t t  Brooom");
        }
        public override void move()
        {
            engine.go();
        }
        public void TurnOff()
        {
            Console.WriteLine("Silence !!!");
        }
    }

    public class Horse:Vehicle
    {
        string breed;
        public Horse (string pBreed, int pCapacity):base(pCapacity)
        {
            breed = pBreed;
        }
        public override void move()
        {
            Console.WriteLine("Bang those coconuts");
        }
        public void Eat()
        {
            Console.WriteLine("Chew Chew");
        }
        public void Poop()
        {
            Console.WriteLine("STINKY!!!");
        }
    }
}
