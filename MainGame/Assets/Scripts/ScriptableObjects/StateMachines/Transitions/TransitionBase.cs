namespace MainGame.ScriptableObjects.StateMachines.Transitions
{
    using MainGame.ScriptableObjects.StateMachines.Conditions;
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using MainGame.ScriptableObjects.StateMachines.States;
    using UnityEngine;

    public abstract class TransitionBase<T> : ScriptableObject, ITransition<T, StateBase<T>>
        where T : IStateMachine<T, StateBase<T>>
    {
        public abstract IState<T, StateBase<T>> NextState { get; }

        public abstract ICondition<T, StateBase<T>> Condition { get; }
    }
}
