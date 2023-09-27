namespace MainGame.ScriptableObjects.StateMachines.Transitions
{
    using MainGame.ScriptableObjects.StateMachines.Conditions;
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using MainGame.ScriptableObjects.StateMachines.States;
    using UnityEngine;

    [CreateAssetMenu(menuName = "MainGame/Scriptable objects/Transitions/Player transition", fileName = nameof(PlayerTransition))]
    public class PlayerTransition : TransitionBase<PlayerStateMachine>
    {
        public override IState<PlayerStateMachine, StateBase<PlayerStateMachine>> NextState => _nextState;

        public override ICondition<PlayerStateMachine, StateBase<PlayerStateMachine>> Condition => _condition;

        [SerializeField]
        private PlayerState _nextState;

        [SerializeField]
        private PlayerCondition _condition;
    }
}
