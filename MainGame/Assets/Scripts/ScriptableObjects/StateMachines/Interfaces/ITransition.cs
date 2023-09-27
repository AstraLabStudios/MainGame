namespace MainGame.ScriptableObjects.StateMachines.Interfaces
{
    public interface ITransition<out TObject, in TState>
        where TObject : IStateMachine<TObject, TState>
        where TState : IState<TObject, TState>
    {
        public abstract IState<TObject, TState> NextState { get; }
        
        public abstract ICondition<TObject, TState> Condition { get; }
    }
}
