using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class MinimallyChargedState : IState
    {
        private ElectricCar aCar;

        // Constructor
        public MinimallyChargedState(ElectricCar car)
        {
            this.aCar = car;
        }

        // Class methods
        public void Charge()
        {
            this.aCar.CurrentState = new LowChargedState(this.aCar);
        }
        public void Uncharge()
        {
            this.aCar.CurrentState = new UnchargedState(this.aCar);
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
            return "Charge level is too low.";
        }
        public string TurnOnRadio()
        {
            return "Charge level is too low.";
        }
    }
}
