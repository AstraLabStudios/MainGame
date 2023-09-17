namespace MainGame.ScriptableObjects.StateMachines
{
    using UnityEngine;
    using UnityEngine.InputSystem;

    [CreateAssetMenu(menuName = "MainGame/Scriptable objects/State machines/Player state machine", fileName = nameof(PlayerStateMachine))]
    public class PlayerStateMachine : StateMachineBase 
    {
        public bool IsMoving { get; private set; }

        public PlayerInput PlayerInput => _playerInput;

        [SerializeField]
        private PlayerInput _playerInput;
    }
}
