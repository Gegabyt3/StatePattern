using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ElectricCar
    {
        // Class variables
        private IState currentState;    // this will be used to determine the state of the car

        // Gets and sets
        public IState CurrentState
        {
            get
            {
                return this.currentState;
            }
            set
            {
                this.currentState = value;
            }
        }

        // Constructor 
        public ElectricCar()
        {
            this.CurrentState = new UnchargedState(this);   // Uncharged state by default
        }

        public ElectricCar(ElectricCar car)
        {
            this.CurrentState = car.CurrentState;
        }




    }
}
