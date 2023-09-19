namespace MainGame.ScriptableObjects.StateMachines
{
    using MainGame.ScriptableObjects.StateMachines.States;
    using MainGame.ScriptableObjects.StateMachines.Transitions;
    using System.Linq;
    using UnityEngine;

    public abstract class StateMachineBase : ScriptableObject
    {
        public StateBase CurrentState => _currentState;

        [Header("State")]
        [SerializeField]
        private StateBase _currentState;

        public void CheckTransition()
        {
            _currentState.UpdateState(this);
            foreach (TransitionBase transition in _currentState.Transitions.Where(transition => transition.Condition.CheckCondition(this)))
            {
                _currentState.ExitState(this);
                _currentState = transition.NextState;
                _currentState.EnterState(this);
            }
        }
    }
}
