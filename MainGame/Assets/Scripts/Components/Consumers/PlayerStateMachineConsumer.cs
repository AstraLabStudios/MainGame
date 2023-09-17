namespace MainGame.Components.Consumers
{
    using MainGame.ScriptableObjects.StateMachines;
    using UnityEngine;
    using static UnityEngine.InputSystem.InputAction;

    public class PlayerStateMachineConsumer : StateMachineConsumerBase<PlayerStateMachine>
    {
        [Header("Components")]
        [SerializeField]
        private CharacterController _characterController;

        protected override void Initialize()
        {
            _stateMachine = Instantiate(_stateMachine);
            
            StateMachine.Controller = _characterController;
            StateMachine.PlayerInput = new InputMaps.PlayerInput();
            StateMachine.PlayerInput.PlayerControls.Move.started += OnMoveInput;
            StateMachine.PlayerInput.PlayerControls.Move.canceled += OnMoveInput;
            StateMachine.PlayerInput.PlayerControls.Move.performed += OnMoveInput;
        }

        private void OnEnable() => StateMachine.PlayerInput.PlayerControls.Enable();

        private void OnDisable() => StateMachine.PlayerInput.PlayerControls.Disable();

        protected override void Update()
        {
            _ = StateMachine.Controller.Move(StateMachine.CurrentMovement * Time.deltaTime);

            base.Update();
        }

        private void OnMoveInput(CallbackContext context)
        {
            StateMachine.CurrentMovementInput = context.ReadValue<Vector2>();
            StateMachine.CurrentMovement.x = StateMachine.CurrentMovementInput.x;
            StateMachine.CurrentMovement.z = StateMachine.CurrentMovementInput.y;
        }
    }
}
