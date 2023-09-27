namespace MainGame.ScriptableObjects.StateMachines.States
{
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using MainGame.ScriptableObjects.StateMachines.Transitions;
    using UnityEngine;

    public abstract class PlayerState : StateBase<PlayerStateMachine> 
    {
        public override ITransition<PlayerStateMachine, StateBase<PlayerStateMachine>>[] Transitions => _transitions;

        [SerializeField]
        private PlayerTransition[] _transitions;
    }
}
