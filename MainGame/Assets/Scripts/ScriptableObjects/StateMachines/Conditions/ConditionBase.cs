namespace MainGame.ScriptableObjects.StateMachines.Conditions
{
    using UnityEngine;

    public abstract class ConditionBase : ScriptableObject
    {
        public abstract bool CheckCondition(StateMachineBase context);
    }
}
