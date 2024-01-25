using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    [CreateAssetMenu(menuName = "FSM/State")]
    public class State : ScriptableObject
    {
        public List<Action> enterActions, updateActions, exitActions;
        public List<Transition> transitions;

        public void OnEnter(StateController controller)
        {
            ExecuteAction(controller, enterActions);
        }

        public void OnUpdate(StateController controller)
        {
            ExecuteAction(controller, updateActions);
            foreach (var transiti in transitions) 
            {
                if (transiti.Decide(controller))
                {
                    controller.Transition(transiti.goToState);
                    return;
                }
            }
        }

        public void OnExit(StateController controller)
        {
            ExecuteAction(controller, exitActions);
        }

        private void ExecuteAction(StateController controller, IEnumerable<Action> actions)
        {
            foreach (Action action in actions)
            {
                action.Act(controller);
            }
        }
    }
}
