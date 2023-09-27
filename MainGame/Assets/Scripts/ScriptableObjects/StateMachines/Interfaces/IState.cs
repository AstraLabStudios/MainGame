namespace MainGame.ScriptableObjects.StateMachines.Interfaces
{
    using MainGame.ScriptableObjects.StateMachines.Transitions;

    public interface IState<out TObject, in TState>
        where TObject : IStateMachine<TObject, TState>
        where TState : IState<TObject, TState>
    {
        public abstract ITransition<TObject, TState>[] Transitions { get; }

        public void EnterState(IStateMachine<TObject, TState> context);

        public void UpdateState(IStateMachine<TObject, TState> context);

        public void ExitState(IStateMachine<TObject, TState> context);
    }
}
