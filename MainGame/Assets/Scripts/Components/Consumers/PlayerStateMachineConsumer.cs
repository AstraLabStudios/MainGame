namespace MainGame.Components.Consumers
{
    using MainGame.ScriptableObjects.StateMachines;

    public class PlayerStateMachineConsumer : StateMachineConsumerBase<PlayerStateMachine>
    {
        protected override void Initialize()
        {
            _stateMachine = Instantiate(_stateMachine);
            StateMachine.PlayerInput
        }
    }
}
