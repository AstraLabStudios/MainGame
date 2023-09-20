namespace MainGame.ScriptableObjects.StateMachines.States
{
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using UnityEngine;

    public abstract class StateBase<T> : ScriptableObject, IState<T, StateBase<T>>
        where T : IStateMachine<T, StateBase<T>>
    {
        public abstract ITransition<T, StateBase<T>>[] Transitions { get; }

        public virtual void EnterState(IStateMachine<T, StateBase<T>> context) { }
               
        public virtual void UpdateState(IStateMachine<T, StateBase<T>> context) { }
               
        public virtual void ExitState(IStateMachine<T, StateBase<T>> context) { }
    }
}
