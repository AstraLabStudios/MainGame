namespace MainGame.ScriptableObjects.StateMachines.Conditions
{
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using MainGame.ScriptableObjects.StateMachines.States;
    using UnityEngine;

    [CreateAssetMenu(menuName = "MainGame/Scriptable objects/Conditions/Player/Is not moving", fileName = nameof(PlayerIsNotMoving))]
    public class PlayerIsNotMoving : PlayerCondition
    {
        public override bool CheckCondition(IStateMachine<PlayerStateMachine, StateBase<PlayerStateMachine>> context)
        {
            PlayerStateMachine castedContext = context as PlayerStateMachine;
            return !castedContext.IsMoving;
        }
    }
}
