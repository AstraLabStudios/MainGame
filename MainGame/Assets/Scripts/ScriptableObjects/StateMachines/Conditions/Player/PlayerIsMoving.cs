namespace MainGame.ScriptableObjects.StateMachines.Conditions
{
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using UnityEngine;

    [CreateAssetMenu(menuName = "MainGame/Scriptable objects/Conditions/Player/Is moving", fileName = nameof(PlayerIsMoving))]
    public class PlayerIsMoving : PlayerCondition
    {
        public override bool CheckCondition(IStateMachine<PlayerStateMachine, States.StateBase<PlayerStateMachine>> context)
        {
            PlayerStateMachine castedContext = context as PlayerStateMachine;
            return castedContext.IsMoving;
        }
    }
}
