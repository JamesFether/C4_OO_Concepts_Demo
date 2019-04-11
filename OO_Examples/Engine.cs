using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Examples
{
    public abstract class Engine
    {
        int kilowatts;
        int weight;

        public Engine(int pKW, int pWeight)
        {
            kilowatts = pKW;
            weight = pWeight;
        }

        public abstract void go();
    }

    public class CombustionEngine:Engine
    {
        int maxFuel;
        int currentFuel;
        string fuelType;

        public CombustionEngine(int pMaxFuel, int pCurrentFuel, string pFuelType,
                                  int pKW, int pWeight):base(pKW, pWeight)
        {
            maxFuel = pMaxFuel;
            currentFuel = pCurrentFuel;
            fuelType = pFuelType;
        }

        public override void go()
        {
            currentFuel = currentFuel - 1;
            Console.WriteLine("Vrrroooooooommmm");
        }

        public void refuel()
        {
            currentFuel = maxFuel;
        }
    }

    public class ElectricEngine : Engine
    {
        int maxCharge;
        int currentCharge;

        public ElectricEngine(int pMaxCharge, int pCurrentCharge, int pKW, 
                                              int pWeight):base(pKW, pWeight)
        {
            maxCharge = pMaxCharge;
            currentCharge = pCurrentCharge;
        }

        public override void go()
        {
            currentCharge = currentCharge - 1;
            Console.WriteLine("Swiiiissshhhh !");
        }

        public void recharge()
        {
            currentCharge = maxCharge;
        }
    }


}
