using System.Collections;
using System.Collections.Generic;
using UnityEditor.DeviceSimulation;
using UnityEngine;


namespace FSM
{
    [System.Serializable]
    public class Transition
    {
        public State goToState;
        public List<Decision> decisions;

        public bool Decide(StateController controller)
        {
            foreach (Decision decision in decisions)
            {
                if (!decision.Decide(controller)) return false;
            }
            return true;
        }
    }
}
