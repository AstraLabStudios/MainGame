namespace MainGame.ScriptableObjects.StateMachines
{
    using MainGame.InputMaps;
    using MainGame.ScriptableObjects.StateMachines.States;
    using UnityEngine;

    [CreateAssetMenu(menuName = "MainGame/Scriptable objects/State machines/Player state machine", fileName = nameof(PlayerStateMachine))]
    public class PlayerStateMachine : StateMachineBase<PlayerState>
    {
        public bool IsMoving => CurrentMovementInput.x != 0 || CurrentMovementInput.y != 0;

        public CharacterController Controller { get; set; }

        public PlayerInput PlayerInput { get; set; }

        public Vector2 CurrentMovementInput { get; set; }

        public Vector3 CurrentMovement = Vector3.zero; // TODO: consider to remove this
    }
}
