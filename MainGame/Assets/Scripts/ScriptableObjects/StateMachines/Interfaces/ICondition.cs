namespace MainGame.ScriptableObjects.StateMachines.Interfaces
{
    public interface ICondition<out TObject, in TState>
        where TObject : IStateMachine<TObject, TState>
        where TState : IState<TObject, TState>
    {
        public abstract bool CheckCondition(IStateMachine<TObject, TState> context);
    }
}
