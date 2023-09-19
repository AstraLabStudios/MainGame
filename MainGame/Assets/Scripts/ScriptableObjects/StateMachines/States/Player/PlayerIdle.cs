namespace MainGame.ScriptableObjects.StateMachines.States
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "MainGame/Scriptable objects/States/Player/Player idle", fileName = nameof(PlayerIdle))]
    public class PlayerIdle : PlayerState
    {
        public override void EnterState(StateMachineBase context) 
        {

        }

        public override void ExitState(StateMachineBase context)
        {

        }

        public override void UpdateState(StateMachineBase context)
        {
            PlayerStateMachine castedContext = context as PlayerStateMachine;

            _ = castedContext.Controller.Move(castedContext.CurrentMovement * Time.deltaTime);
        }
    }
}
