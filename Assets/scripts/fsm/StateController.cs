using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FSM
{
    public class StateController : MonoBehaviour
    {
        public State initialState;
        private State currentState;

        private void Start()
        {
            Transition(initialState);
        }

        private void Update()
        {
            if (currentState == null) return;
            currentState.OnUpdate(this);
        }

        public void Transition(State state)
        {
            if (currentState != null) currentState.OnExit(this);
            currentState = state;
            currentState.OnEnter(this);
        }
    }
}

