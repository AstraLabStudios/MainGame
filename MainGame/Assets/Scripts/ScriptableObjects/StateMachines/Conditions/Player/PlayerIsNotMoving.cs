namespace MainGame.ScriptableObjects.StateMachines.Conditions
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "MainGame/Scriptable objects/Conditions/Player/Is not moving", fileName = nameof(PlayerIsNotMoving))]
    public class PlayerIsNotMoving : PlayerCondition
    {
        public override bool CheckCondition(StateMachineBase context)
        {
            PlayerStateMachine castedContext = context as PlayerStateMachine;
            return !castedContext.IsMoving;
        }
    }
}
