using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FSM
{
    [CreateAssetMenu(menuName = "FSM/Actions/MoveTowardsPlayer")]
    public class MoveTowardsPlayer : Action
    {
        public override void Act(StateController controller)
        {
            var mb = controller.GetComponent<IMovementBehaviour>();
            var target = GameManager.instance.playerHealth.transform.position;
            mb.MoveToPoint(target);
        }
    }
}
