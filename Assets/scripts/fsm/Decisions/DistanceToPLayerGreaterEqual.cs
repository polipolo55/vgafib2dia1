using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    [CreateAssetMenu(menuName = "FSM/Decisions/DistanceToPLayerGreaterEqual")]
    public class DistanceToPLayerGreaterEqual : Decision
    {
        public float distance;
        public override bool Decide(StateController controller)
        {
            return Vector3.Distance(controller.transform.position, GameManager.instance.playerHealth.transform.position) >= distance;
        }
    }
}
