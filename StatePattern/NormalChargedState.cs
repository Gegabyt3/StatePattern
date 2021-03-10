using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class NormalChargedState : IState
    {
        private ElectricCar aCar;

        // Constructor
        public NormalChargedState(ElectricCar car)
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
            this.aCar.CurrentState = new LowChargedState(this.aCar);
        }
        public string TurnOnEngine()
        {
            return "Engine is on.";
        }
        public string TurnOnHazardLights()
        {
            return "Hazard lights are on.";
        }
        public string TurnOnAirConditioner()
        {
            return "Air Conditioner is on.";
        }
        public string TurnOnRadio()
        {
            return "Radio is on.";
        }
    }
}
