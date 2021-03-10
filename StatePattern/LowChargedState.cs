using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class LowChargedState : IState
    {
        private ElectricCar aCar;

        // Constructor
        public LowChargedState(ElectricCar car)
        {
            this.aCar = car;
        }

        // Class methods
        public void Charge()
        {
            this.aCar.CurrentState = new NormalChargedState(this.aCar);
        }
        public void Uncharge()
        {
            this.aCar.CurrentState = new MinimallyChargedState(this.aCar);
        }
        public string TurnOnEngine()
        {
            return "Charge level is too low.";
        }
        public string TurnOnHazardLights()
        {
            return "Hazard lights are on.";
        }
        public string TurnOnAirConditioner()
        {
            return "Fan is now on.";
        }
        public string TurnOnRadio()
        {
            return "Radio is on.";
        }
    }
}
