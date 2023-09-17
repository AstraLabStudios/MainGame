namespace MainGame.ScriptableObjects.StateMachines.States
{
    using MainGame.ScriptableObjects.StateMachines.Transitions;
    using UnityEngine;

    public abstract class StateBase : ScriptableObject
    {
        public TransitionBase[] Transitions => _transitions;

        [SerializeField]
        private TransitionBase[] _transitions;

        public abstract void EnterState(StateMachineBase context);

        public abstract void UpdateState(StateMachineBase context);

        public abstract void ExitState(StateMachineBase context);
    }
}
