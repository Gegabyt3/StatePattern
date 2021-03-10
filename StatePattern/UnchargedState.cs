using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class UnchargedState : IState
    {
        // Class variables
        private ElectricCar aCar;

        // Constructor
        public UnchargedState(ElectricCar car)
        {
            this.aCar = car;
        }

        // Class methods
        public void Charge()    // Changes state one up
        {
            this.aCar.CurrentState = new MinimallyChargedState(this.aCar);
        }
        public void Uncharge()  // changes state one down
        {
            this.aCar.CurrentState = new UnchargedState(this.aCar);
        }
        public string TurnOnEngine()
        {
            return "";
        }
        public string TurnOnHazardLights()
        {
            return "";
        }
        public string TurnOnAirConditioner()
        {
            return "";
        }
        public string TurnOnRadio()
        {
            return "";
        }
    }
}
