namespace MainGame.ScriptableObjects.StateMachines.Conditions
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "MainGame/Scriptable objects/Conditions/Player/Is moving", fileName = nameof(PlayerIsMoving))]
    public class PlayerIsMoving : PlayerCondition
    {
        public override bool CheckCondition(StateMachineBase context)
        {
            PlayerStateMachine castedContext = context as PlayerStateMachine;
            return castedContext.IsMoving;
        }
    }
}
