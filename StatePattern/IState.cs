using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    // State interface that will be implemented by all the state objects
    public interface IState
    {
        // State methods
        void Charge();  // This changes the state of the car object to one above
        void Uncharge();    // This changes the state of the car object to one down
        string TurnOnEngine();
        string TurnOnHazardLights();
        string TurnOnAirConditioner();
        string TurnOnRadio();
    }
}
