using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Program
    {
        // This program demonstrates the state design pattern by using an electric car as a subject 
        // to 4 states: Uncharged, minimally charged, low charged, normal charged. Each state prints
        // different strings.
        public static void Main(string[] args)
        {
            ElectricCar aCar = new ElectricCar();

            // Uncharged level by default
            Console.WriteLine(aCar.CurrentState.TurnOnEngine());
            Console.WriteLine(aCar.CurrentState.TurnOnHazardLights());
            Console.WriteLine(aCar.CurrentState.TurnOnAirConditioner());
            Console.WriteLine(aCar.CurrentState.TurnOnRadio());
            Console.WriteLine("\n\n");

            // Minimal charged state
            aCar.CurrentState.Charge();
            Console.WriteLine(aCar.CurrentState.TurnOnEngine());
            Console.WriteLine(aCar.CurrentState.TurnOnHazardLights());
            Console.WriteLine(aCar.CurrentState.TurnOnAirConditioner());
            Console.WriteLine(aCar.CurrentState.TurnOnRadio());
            Console.WriteLine("\n\n");

            // Low Charged state
            aCar.CurrentState.Charge();
            Console.WriteLine(aCar.CurrentState.TurnOnEngine());
            Console.WriteLine(aCar.CurrentState.TurnOnHazardLights());
            Console.WriteLine(aCar.CurrentState.TurnOnAirConditioner());
            Console.WriteLine(aCar.CurrentState.TurnOnRadio());
            Console.WriteLine("\n\n");

            // Normal Charged state
            aCar.CurrentState.Charge();
            Console.WriteLine(aCar.CurrentState.TurnOnEngine());
            Console.WriteLine(aCar.CurrentState.TurnOnHazardLights());
            Console.WriteLine(aCar.CurrentState.TurnOnAirConditioner());
            Console.WriteLine(aCar.CurrentState.TurnOnRadio());
            Console.WriteLine("\n\n");

            // Uncharged back to low charged state
            aCar.CurrentState.Uncharge();
            Console.WriteLine(aCar.CurrentState.TurnOnEngine());
            Console.WriteLine(aCar.CurrentState.TurnOnHazardLights());
            Console.WriteLine(aCar.CurrentState.TurnOnAirConditioner());
            Console.WriteLine(aCar.CurrentState.TurnOnRadio());

            Console.ReadLine();
        }
    }
}
