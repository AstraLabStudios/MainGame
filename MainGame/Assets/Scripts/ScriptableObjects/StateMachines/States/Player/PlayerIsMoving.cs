namespace MainGame.ScriptableObjects.StateMachines.States
{
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using System.Threading;
    using UnityEngine;

    [CreateAssetMenu(menuName = "MainGame/Scriptable objects/States/Player/Player is moving", fileName = nameof(PlayerIsMoving))]
    public class PlayerIsMoving : PlayerState
    {
        public override void UpdateState(IStateMachine<PlayerStateMachine, StateBase<PlayerStateMachine>> context) 
        {
            PlayerStateMachine castedContext = context as PlayerStateMachine;

            _ = castedContext.Controller.Move(castedContext.CurrentMovement * Time.deltaTime);
        }
    }
}
