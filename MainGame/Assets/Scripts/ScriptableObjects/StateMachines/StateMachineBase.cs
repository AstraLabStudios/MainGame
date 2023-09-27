namespace MainGame.ScriptableObjects.StateMachines
{
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using System.Linq;
    using UnityEngine;

    public abstract class StateMachineBase<T> : ScriptableObject, IStateMachine<StateMachineBase<T>, T>
        where T : IState<StateMachineBase<T>, T>
    {
        public T CurrentState => _currentState;

        [Header("State")]
        [SerializeField]
        private T _currentState;

        public void CheckTransition()
        {
            _currentState.UpdateState(this);

            foreach (ITransition<StateMachineBase<T>, T> transition 
                in _currentState.Transitions.Where(transition => transition.Condition.CheckCondition(this)))
            {
                _currentState.ExitState(this);
                _currentState = (T)transition.NextState;
                _currentState.EnterState(this);
            }
        }
    }
}
