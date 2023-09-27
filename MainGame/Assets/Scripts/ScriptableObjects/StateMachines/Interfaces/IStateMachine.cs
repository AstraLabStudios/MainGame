namespace MainGame.ScriptableObjects.StateMachines.Interfaces
{
    public interface IStateMachine<in TObject, out TState>
        where TObject : IStateMachine<TObject, TState>
        where TState : IState<TObject, TState>
    {
        public void CheckTransition();
    }
}
