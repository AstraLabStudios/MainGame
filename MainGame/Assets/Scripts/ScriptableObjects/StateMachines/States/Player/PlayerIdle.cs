namespace MainGame.ScriptableObjects.StateMachines.States
{
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using UnityEngine;

    [CreateAssetMenu(menuName = "MainGame/Scriptable objects/States/Player/Player idle", fileName = nameof(PlayerIdle))]
    public class PlayerIdle : PlayerState
    {
        public override void UpdateState(IStateMachine<PlayerStateMachine, StateBase<PlayerStateMachine>> context)
        {
            PlayerStateMachine castedContext = context as PlayerStateMachine;

            _ = castedContext.Controller.Move(castedContext.CurrentMovement * Time.deltaTime);
        }
    }
}
