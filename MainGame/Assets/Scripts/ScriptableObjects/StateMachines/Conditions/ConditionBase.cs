namespace MainGame.ScriptableObjects.StateMachines.Conditions
{
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using MainGame.ScriptableObjects.StateMachines.States;
    using UnityEngine;

    public abstract class ConditionBase<T> : ScriptableObject, ICondition<T, StateBase<T>>
        where T : IStateMachine<T, StateBase<T>>
    {
        public abstract bool CheckCondition(IStateMachine<T, StateBase<T>> context);
    }
}
