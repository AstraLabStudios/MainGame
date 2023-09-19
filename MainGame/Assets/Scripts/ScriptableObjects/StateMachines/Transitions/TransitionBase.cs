namespace MainGame.ScriptableObjects.StateMachines.Transitions
{
    using MainGame.ScriptableObjects.StateMachines.Conditions;
    using MainGame.ScriptableObjects.StateMachines.States;
    using UnityEngine;

    public abstract class TransitionBase : ScriptableObject
    {
        public StateBase NextState => _nextState;

        public ConditionBase Condition => _condition;

        [SerializeField]
        private StateBase _nextState;

        [SerializeField]
        private ConditionBase _condition;
    }
}
