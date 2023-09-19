namespace MainGame.Components.Consumers
{
    using MainGame.ScriptableObjects.StateMachines;
    using UnityEngine;

    public abstract class StateMachineConsumerBase<T> : MonoBehaviour
        where T : StateMachineBase
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
