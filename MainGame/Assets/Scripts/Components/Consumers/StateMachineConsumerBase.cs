namespace MainGame.Components.Consumers
{
    using MainGame.ScriptableObjects.StateMachines.Interfaces;
    using UnityEngine;

    public abstract class StateMachineConsumerBase<T, J> : MonoBehaviour
        where T : IStateMachine<T, J>
        where J : IState<T, J>
    {
        public T StateMachine => _stateMachine;

        [Header("State machine")]
        [SerializeField]
        protected T _stateMachine;

        protected virtual void Awake() => Initialize();

        protected virtual void Update() => _stateMachine.CheckTransition();

        /// <summary>
        /// Instantiate a copy of the machine state here if you want to using more then one at the same time. 
        /// </summary>
        protected abstract void Initialize();
    }
}
